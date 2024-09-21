using NagMe.Enums;
using NagMe.Extensions;
using NagMe.IO;
using NagMe.Reminders;
using OpenAI_API.Models;
using System.Data;
using System.Text.Json;

namespace NagMe.AI
{
    public class AIUpdateManager
    {
        private static AIUpdateManager? _current;
        
        private OpenAI_API.OpenAIAPI _openAiApiClient;
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
            _openAiApiClient = new OpenAI_API.OpenAIAPI(apiKey);
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
                    Content = text
                };
                _resources.Add(newResource);

                var resourceJson = JsonSerializer.Serialize(newResource);
                await File.WriteAllTextAsync(newResource.GetResourcePath(), resourceJson);
                return newResource;
            }

            var i = new Random(Environment.TickCount).Next(0, allTextResources.Count);
            return allTextResources[i];
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

            var chat = _openAiApiClient.Chat.CreateConversation();
            chat.Model = Model.GPT4;
            chat.RequestParameters.Temperature = 0.7d;
            chat.RequestParameters.TopP = 0.8d;
            chat.AppendSystemMessage(prompt);
            chat.AppendUserInput($"Name: {reminder.Name}\r\nDescription: {reminder.Description}");
            var response = await chat.GetResponseFromChatbotAsync();
            return response;
        }

        private void ExpireResources()
        {
            var maxLifeTime = Configuration.Configuration.Current.AIResourceLifeTimePeriod.CreateTimeSpan(Configuration.Configuration.Current.AIResourceLifeTime);
            var expiredResources = _resources.Where(x =>
                DateTime.Now.Subtract(x.CreatedAt!.Value) > maxLifeTime);
            foreach(var resource in expiredResources)
            {
                resource.DeleteContent();
                _resources.Remove(resource);
            }
        }

    }
}
