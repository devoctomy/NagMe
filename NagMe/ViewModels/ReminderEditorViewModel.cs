using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NagMe.Enums;
using NagMe.Reminders;
using System.Collections.ObjectModel;

namespace NagMe.ViewModels
{
    public partial class ReminderEditorViewModel : ObservableObject
    {
        private Form _parentForm;
        private Reminder _reminder;

        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string _description = string.Empty;

        [ObservableProperty]
        private int _interval;

        [ObservableProperty]
        private IntervalPeriod _period;

        [ObservableProperty]
        private ObservableCollection<string> _periods;

        public ReminderEditorViewModel(
            Form parentForm,
            Reminder reminder)
        {
            _parentForm = parentForm;
            _reminder = reminder;
            Periods = new ObservableCollection<string>(Enum.GetNames(typeof(IntervalPeriod)));
            ReadReminder();
        }

        private void ReadReminder()
        {
            Name = _reminder.Name;
            Description = _reminder.Description;
            Interval = _reminder.Interval;
            Period = _reminder.Period;
        }

        [RelayCommand()]
        private void OkButton()
        {
            _reminder.Name = Name;
            _reminder.Description = Description;
            _reminder.Interval = Interval;
            _reminder.Period = Period;
            _parentForm.DialogResult = DialogResult.OK;
        }
    }
}
