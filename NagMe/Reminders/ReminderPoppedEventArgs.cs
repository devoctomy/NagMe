namespace NagMe.Reminders
{
    public class ReminderPoppedEventArgs : EventArgs
    {
        public Reminder Reminder { get; set; }
        public DateTime PoppedAt { get; set; }

        public ReminderPoppedEventArgs(
            Reminder reminder,
            DateTime poppedAt)
        {
            Reminder = reminder;
            PoppedAt = poppedAt;
        }
    }
}
