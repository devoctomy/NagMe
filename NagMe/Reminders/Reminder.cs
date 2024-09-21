using NagMe.Enums;
using NagMe.Extensions;
using System.Text.Json.Serialization;

namespace NagMe.Reminders
{
    public class Reminder
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsEnabled { get; set; } = false;

        // General
        public string Name { get; set; } = "New Reminder";
        public string Description { get; set; } = "Give your reminder a helpful description here so that you know exactly why you are being nagged.";
        
        // Timing
        public int Interval { get; set; } = 5;
        public ShortIntervalPeriod Period { get; set; } = ShortIntervalPeriod.Minutes;

        // Notification
        public NotificationType NotificationType { get; set; } = NotificationType.MessageBox;

        // Notification : Full Screen
        public int FullScreenBackgroundOpacity { get; set; } = 90;
        public int NotificationFullScreenDisplayTime { get; set; } = 30;
        public ShortIntervalPeriod NotificationFullScreenDisplayPeriod { get; set; } = ShortIntervalPeriod.Seconds;

        // AI
        public bool IsAIEnabled { get; set; } = false;

        [JsonIgnore]
        public DateTime StartedAt { get; set; }

        public TimeSpan GetRemainingTimeAsTimeSpan()
        {
            return Period.CreateTimeSpan(Interval).Subtract(DateTime.Now.Subtract(StartedAt));
        }

        public void Restart()
        {
            StartedAt = DateTime.Now;
        }

        public override string ToString()
        {
            return Name;
        }

        public Reminder Clone()
        {
            return (Reminder)MemberwiseClone();
        }
    }
}
