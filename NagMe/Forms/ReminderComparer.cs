using NagMe.Reminders;
using System.Collections;

namespace NagMe.Forms
{
    public class ReminderComparer : IComparer
    {
        public int Compare(
            object? x,
            object? y)
        {
            var itemX = (ListViewItem)x!;
            var itemY = (ListViewItem)y!;

            var reminderX = (Reminder)itemX.Tag!;
            var reminderY = (Reminder)itemY.Tag!;

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
