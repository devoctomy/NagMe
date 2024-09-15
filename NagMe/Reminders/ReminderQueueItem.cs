namespace NagMe.Reminders
{
    public class ReminderQueueItem
    {
        public Reminder Reminder { get; set; }
        public ListViewItem ListViewItem { get; set; }

        public ReminderQueueItem(
            Reminder reminder,
            ListViewItem listViewItem)
        {
            Reminder = reminder;
            ListViewItem = listViewItem;
        }
    }
}
