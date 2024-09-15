using NagMe.Reminders;

namespace NagMe.Forms
{
    public class ReminderComparer : IComparer<ReminderQueueItem>
    {
        public int Compare(
            ReminderQueueItem? x,
            ReminderQueueItem? y)
        {
            var reminderX = x!.Reminder;
            var reminderY = y!.Reminder;

            if (!reminderX.IsEnabled && !reminderY.IsEnabled)
            {
                return 0;
            }

            if (!reminderX.IsEnabled)
            {
                return 1;
            }

            if(!reminderY.IsEnabled)
            {
                return -1;
            }

            var remainingX = reminderX.GetRemainingTimeAsTimeSpan();
            var remainingY = reminderY.GetRemainingTimeAsTimeSpan();

            return remainingX.CompareTo(remainingY);
        }
    }
}
