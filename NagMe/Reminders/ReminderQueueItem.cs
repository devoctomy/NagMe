using CommunityToolkit.Mvvm.ComponentModel;

namespace NagMe.Reminders
{
    public partial class ReminderQueueItem : ObservableObject
    {
        public Reminder Reminder { get; }

        [ObservableProperty]
        private string _remainingTime;

        [ObservableProperty]
        private string _totalCount;

        public ReminderQueueItem(
            Reminder reminder,
            string remainingTime,
            string totalCount)
        {
            Reminder = reminder;
            RemainingTime = remainingTime;
            TotalCount = totalCount;
        }
    }
}
