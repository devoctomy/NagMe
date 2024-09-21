using NagMe.Enums;
using NagMe.IO;
using NagMe.Reminders;

namespace NagMe.AI
{
    public class AIResourceEntry
    {
        public string? Id { get; set; }
        public string? ReferencedReminderId { get; set; }
        public AIResourceType? ResourceType { get; set; }
        public AIResourceSubType? ResourceSubType { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string? Content { get; set; }
        public string? ContentPath { get; set; }

        public AIResourceEntry()
        {
        }

        public AIResourceEntry(
            AIResourceType type,
            AIResourceSubType subType,
            Reminder referencedReminder)
        {
            Id = Guid.NewGuid().ToString();
            ResourceType = type;
            ResourceSubType = subType;
            ReferencedReminderId = referencedReminder.Id;
            CreatedAt = DateTime.Now;
        }

        public string GetResourcePath()
        {
            return Path.Combine(PathManager.Current.GetUserResourcesPath(), $"{Id}.json");
        }

        public void DeleteContent()
        {
            File.Delete(GetResourcePath());

            if (ContentPath == null)
            {
                return;
            }

            string allowedBaseDirectory = PathManager.Current.GetUserResourcesPath();
            string fullContentPath = Path.GetFullPath(ContentPath);
            string fullBaseDirectory = Path.GetFullPath(allowedBaseDirectory);

            if (fullContentPath.StartsWith(fullBaseDirectory, StringComparison.OrdinalIgnoreCase))
            {
                if (File.Exists(fullContentPath))
                {
                    File.Delete(fullContentPath);
                }
            }
            else
            {
                throw new UnauthorizedAccessException("Attempted to delete content outside of the applications resource directory.");
            }
        }

        public override string ToString()
        {
            return string.IsNullOrEmpty(Content) ? "Unset" : Content.Trim('\"');
        }
    }
}
