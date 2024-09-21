using NagMe.Enums;
using NagMe.Extensions;
using NagMe.Reminders;
using System.Data;

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
        }

        public string GetTextResource(
            AIResourceSubType subType,
            Reminder referencedReminder)
        {
            ExpireResources();

            var allTextResources = _resources.Where(x =>
                x.Type == Enums.AIResourceType.Text &&
                x.SubType == subType &&
                x.ReferencedReminderId == referencedReminder.Id);

            // How many resources of each type do we want to cache?

            throw new NotImplementedException();
        }

        private void ExpireResources()
        {
            var maxLifeTime = Configuration.Configuration.Current.AIResourceLifeTimePeriod.CreateTimeSpan(Configuration.Configuration.Current.AIResourceLifeTime);
            var expiredResources = _resources.Where(x =>
                DateTime.Now.Subtract(x.CreatedAt) > maxLifeTime);
            foreach(var resource in expiredResources)
            {
                resource.DeleteContent();
                _resources.Remove(resource);
            }
        }

    }
}
