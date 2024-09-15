using CommunityToolkit.Mvvm.ComponentModel;

namespace NagMe.Reminders
{
    public partial class ReminderQueueItem : ObservableObject
    {
        public Reminder Reminder { get; }
        public string Id { get; }

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _remainingTime;

        [ObservableProperty]
        private string _totalCount;

        public ReminderQueueItem(
            Reminder reminder,
            string id,
            string name,
            string remainingTime,
            string totalCount)
        {
            Reminder = reminder;
            Id = id;
            Name = name;
            RemainingTime = remainingTime;
            TotalCount = totalCount;
        }
    }
}
