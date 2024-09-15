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
        private NotificationType _notificationType;

        [ObservableProperty]
        private ObservableCollection<IntervalPeriod> _periods;

        [ObservableProperty]
        private ObservableCollection<NotificationType> _notificationTypes;

        public ReminderEditorViewModel(
            Form parentForm,
            Reminder reminder)
        {
            _parentForm = parentForm;
            _reminder = reminder;
            var periods = Enum.GetNames(typeof(IntervalPeriod)).Select(x => Enum.Parse<IntervalPeriod>(x)).ToList();
            Periods = new ObservableCollection<IntervalPeriod>(periods);
            var notificationTypes = Enum.GetNames(typeof(NotificationType)).Select(x => Enum.Parse<NotificationType>(x)).ToList();
            NotificationTypes = new ObservableCollection<NotificationType>(notificationTypes);
            ReadReminder();
        }

        private void ReadReminder()
        {
            Name = _reminder.Name;
            Description = _reminder.Description;
            Interval = _reminder.Interval;
            Period = _reminder.Period;
            NotificationType = _reminder.NotificationType;
        }

        [RelayCommand()]
        private void OkButton()
        {
            _reminder.Name = Name;
            _reminder.Description = Description;
            _reminder.Interval = Interval;
            _reminder.Period = Period;
            _reminder.NotificationType = NotificationType;
            _parentForm.DialogResult = DialogResult.OK;
        }
    }
}
