using NagMe.Enums;
using System.Text.Json.Serialization;

namespace NagMe.Reminders
{
    public class Reminder
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public bool IsEnabled { get; set; } = false;
        public string Name { get; set; } = "New Reminder";
        public string Description { get; set; } = "Give your reminder a helpful description here so that you know exactly why you are being nagged.";
        
        // Timing
        public int Interval { get; set; } = 5;
        public IntervalPeriod Period { get; set; } = IntervalPeriod.Minutes;

        // Notification
        public NotificationType NotificationType { get; set; } = NotificationType.MessageBox;

        // Notification : Full Screen
        public int FullScreenBackgroundOpacity { get; set; } = 90;
        public int NotificationFullScreenDisplayTime { get; set; } = 30;
        public IntervalPeriod NotificationFullScreenDisplayPeriod { get; set; } = IntervalPeriod.Seconds;

        // AI
        public bool IsAIEnabled { get; set; } = false;

        [JsonIgnore]
        public DateTime StartedAt { get; set; }

        public TimeSpan GetIntervalAsTimeSpan()
        {
            switch(Period)
            {
                case IntervalPeriod.Seconds:
                    {
                        return new TimeSpan(0, 0, Interval);
                    }

                case IntervalPeriod.Minutes:
                    {
                        return new TimeSpan(0, Interval, 0);
                    }

                case IntervalPeriod.Hours:
                    {
                        return new TimeSpan(Interval, 0, 0);
                    }

                default:
                    { 
                        throw new InvalidOperationException("Invalid interval period.");
                    }
            }
        }

        public TimeSpan GetRemainingTimeAsTimeSpan()
        {
            return GetIntervalAsTimeSpan().Subtract(DateTime.Now.Subtract(StartedAt));
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
