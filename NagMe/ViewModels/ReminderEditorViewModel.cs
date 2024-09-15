using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NagMe.Enums;
using NagMe.Reminders;
using System.Collections.ObjectModel;

namespace NagMe.ViewModels
{
    public partial class ReminderEditorViewModel : ObservableObject
    {
        private Reminder _reminder;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        public ReminderEditorViewModel(Reminder reminder)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
        {
            _reminder = reminder;
            EnumeratePeriods();
            ReadReminder();
        }

        [ObservableProperty]
        private string _name;

        [ObservableProperty]
        private string _description;

        [ObservableProperty]
        private int _interval;

        [ObservableProperty]
        private IntervalPeriod _period ;

        [ObservableProperty]
        private ObservableCollection<string> _periods;

        private void EnumeratePeriods()
        {
            Periods = new ObservableCollection<string>(Enum.GetNames(typeof(IntervalPeriod)));
        }

        private void ReadReminder()
        {
            Name = _reminder.Name;
            Description = _reminder.Description;
            Interval = _reminder.Interval;
            Period = _reminder.Period;
        }

        [RelayCommand()]
        private void UpdateReminder()
        {
            _reminder.Name = Name;
            _reminder.Description = Description;
            _reminder.Interval = Interval;
            _reminder.Period = Period;
        }
    }
}
