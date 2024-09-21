using NagMe.Enums;
using NagMe.IO;
using NagMe.Reminders;

namespace NagMe.AI
{
    public class AIResourceEntry
    {
        public string Id { get; set; }
        public string ReferencedReminderId { get; set; }
        public AIResourceType Type { get; set; }
        public AIResourceSubType SubType { get; set; }
        public DateTime CreatedAt { get; set; }
        public string? ContentPath { get; set; }

        public AIResourceEntry(Reminder referencedReminder)
        {
            Id = Guid.NewGuid().ToString();
            ReferencedReminderId = Guid.NewGuid().ToString();
            CreatedAt = DateTime.Now;
        }

        public void DeleteContent()
        {
            if(ContentPath == null)
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
    }
}
