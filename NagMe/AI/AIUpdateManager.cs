using NagMe.Enums;
using NagMe.Extensions;
using NagMe.IO;
using NagMe.Reminders;
using OpenAI.Chat;
using OpenAI.Images;
using System.Data;
using System.Text.Json;

namespace NagMe.AI
{
    public class AIUpdateManager
    {
        private static AIUpdateManager? _current;
        
        private OpenAI.OpenAIClient _openAiApiClient;
        private List<AIResourceEntry> _resources;

        public static AIUpdateManager Current
        {
            get
            {
                if(_current == null)
                {
                    _current = new AIUpdateManager();
                }
                return _current;
            }
        }

        private AIUpdateManager()
        {
            var apiKey = Configuration.Configuration.Current.OpenAIApiKey;
            _openAiApiClient = new OpenAI.OpenAIClient(apiKey);
            _resources = new List<AIResourceEntry>();
            LoadCachedResources();
        }

        private void LoadCachedResources()
        {
            var path = PathManager.Current.GetUserResourcesPath();
            var resources = Directory.GetFiles(path, "*.json");
            foreach(var resource in resources)
            {
                var json = File.ReadAllText(resource);
                var entry = JsonSerializer.Deserialize<AIResourceEntry>(json);
                if(entry == null)
                {
                    continue;
                }

                _resources.Add(entry);
            }
        }

        public async Task<AIResourceEntry> GetTextResource(
            AIResourceSubType subType,
            Reminder referencedReminder)
        {
            ExpireResources();

            var allTextResources = _resources.Where(x =>
                x.ResourceType == Enums.AIResourceType.Text &&
                x.ResourceSubType == subType &&
                x.ReferencedReminderId == referencedReminder.Id).ToList();

            var limit = subType == AIResourceSubType.AlertTitleText ?
                Configuration.Configuration.Current.AIResourceAlertTitleLimit :
                Configuration.Configuration.Current.AIResourceAlertMessageLimit;

            if (allTextResources.Count < limit)
            {
                var text = await GenerateTextResource(referencedReminder, subType);
                var newResource = new AIResourceEntry(
                    AIResourceType.Text,
                    subType,
                    referencedReminder)
                {
                    Content = System.Text.Encoding.UTF8.GetBytes(text)
                };
                _resources.Add(newResource);

                var resourceJson = JsonSerializer.Serialize(newResource);
                await File.WriteAllTextAsync(newResource.GetResourcePath(), resourceJson);
                return newResource;
            }

            var i = new Random(Environment.TickCount).Next(0, allTextResources.Count);
            return allTextResources[i];
        }

        public async Task<AIResourceEntry> GetImageResource(
            AIResourceSubType subType,
            Reminder referencedReminder,
            string overrideMessage = "")
        {
            ExpireResources();

            var allImageResources = _resources.Where(x =>
                x.ResourceType == Enums.AIResourceType.Image &&
                x.ResourceSubType == subType &&
                x.ReferencedReminderId == referencedReminder.Id).ToList();

            var limit = Configuration.Configuration.Current.AIResourceAlertImageLimit;

            if (allImageResources.Count < limit)
            {
                var imageBytes = await GenerateImageResource(referencedReminder, subType);
                var newResource = new AIResourceEntry(
                    AIResourceType.Image,
                    subType,
                    referencedReminder)
                {
                    Content = imageBytes
                };
                _resources.Add(newResource);

                var resourceJson = JsonSerializer.Serialize(newResource);
                await File.WriteAllTextAsync(newResource.GetResourcePath(), resourceJson);
                return newResource;
            }

            var i = new Random(Environment.TickCount).Next(0, allImageResources.Count);
            return allImageResources[i];
        }

        private async Task<string> GenerateTextResource(
            Reminder reminder,
            AIResourceSubType subType)
        {
            var prompt = string.Empty;
            switch (subType)
            {
                case AIResourceSubType.AlertTitleText:
                    {
                        prompt = await File.ReadAllTextAsync("Data/PromptTemplates/GenerateTextResourcePrompt_AlertTitle.txt");

                        break;
                    }

                case AIResourceSubType.AlertMessageText:
                    {
                        prompt = await File.ReadAllTextAsync("Data/PromptTemplates/GenerateTextResourcePrompt_AlertMessage.txt");

                        break;
                    }

                default:
                    {
                        throw new NotImplementedException();
                    }
            }

            try
            {

                var chatClient = _openAiApiClient.GetChatClient("gpt-4.1-nano");
                var chatMessages = new List<ChatMessage>
                {
                    ChatMessage.CreateSystemMessage(prompt),
                    ChatMessage.CreateUserMessage($"Name: {reminder.Name}\r\nDescription: {reminder.Description}")
                };
                var response = await chatClient.CompleteChatAsync(chatMessages);                
                return response.Value.Content[0].Text;
            }
            catch(Exception ex)
            {
                throw new Exception($"Error generating text: {ex.Message}");
            }
        }

        private async Task<byte[]> GenerateImageResource(
            Reminder reminder,
            AIResourceSubType subType,
            string overrideMessage = "")
        {
            var prompt = string.Empty;
            switch (subType)
            {
                case AIResourceSubType.AlertBackgroundImage:
                    {
                        prompt = await File.ReadAllTextAsync("Data/PromptTemplates/GenerateImageResourcePrompt_BackgroundImage.txt");
                        prompt = prompt.Replace("{Message}", $"{(string.IsNullOrEmpty(overrideMessage) ? reminder.Description : overrideMessage)}");

                        break;
                    }

                default:
                    {
                        throw new NotImplementedException();
                    }
            }

            try
            {
                var imageClient = _openAiApiClient.GetImageClient("gpt-image-1");

                var imageGenerationOptions = new ImageGenerationOptions
                {
                    Size = GeneratedImageSize.W1024xH1024
                };
                var result = await imageClient.GenerateImagesAsync(prompt, 1, imageGenerationOptions);
                return result.Value[0].ImageBytes.ToArray();
            }
            catch (Exception ex)
            {
                throw new Exception($"Error generating image: {ex.Message}");
            }
        }

        private void ExpireResources()
        {
            var maxLifeTime = Configuration.Configuration.Current.AIResourceLifeTimePeriod.CreateTimeSpan(Configuration.Configuration.Current.AIResourceLifeTime);
            var expiredResources = _resources.Where(x =>
                DateTime.Now.Subtract(x.CreatedAt!.Value) > maxLifeTime)
                .ToArray();
            foreach(var resource in expiredResources)
            {
                resource.DeleteContent();
                _resources.Remove(resource);
            }
        }

    }
}
