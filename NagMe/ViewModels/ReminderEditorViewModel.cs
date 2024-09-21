using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NagMe.Enums;
using NagMe.Reminders;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace NagMe.ViewModels
{
    public partial class ReminderEditorViewModel : ObservableObject
    {
        private Form _parentForm;
        private Reminder _reminder;

        // General
        [ObservableProperty]
        private string _name = string.Empty;

        [ObservableProperty]
        private string _description = string.Empty;

        // Timing
        [ObservableProperty]
        private int _interval;

        [ObservableProperty]
        private IntervalPeriod _period;

        // Notification
        [ObservableProperty]
        private NotificationType _notificationType;

        [ObservableProperty]
        private ObservableCollection<NotificationType> _notificationTypes;

        [ObservableProperty]
        private int _selectedNotificationTabIndex;

        // Notification : Full Screen
        [ObservableProperty]
        private int _fullScreenBackgroundOpacity;

        [ObservableProperty]
        private int _fullScreenDisplayTime;

        [ObservableProperty]
        private IntervalPeriod _fullScreenDisplayPeriod;

        // AI
        [ObservableProperty]
        private bool _isAIEnabled;

        // Common
        [ObservableProperty]
        private ObservableCollection<IntervalPeriod> _periods;

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

            this.PropertyChanged += ReminderEditorViewModel_PropertyChanged;    
        }

        private void ReminderEditorViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case "NotificationType":
                    {
                        SelectedNotificationTabIndex = (int)NotificationType - 1;

                        break;
                    }
            }
        }

        private void ReadReminder()
        {
            // General
            Name = _reminder.Name;
            Description = _reminder.Description;

            // Timing
            Interval = _reminder.Interval;
            Period = _reminder.Period;

            // Notification
            NotificationType = _reminder.NotificationType;
            FullScreenBackgroundOpacity = _reminder.FullScreenBackgroundOpacity;

            // Notification : Full Screen
            FullScreenDisplayTime = _reminder.NotificationFullScreenDisplayTime;
            FullScreenDisplayPeriod = _reminder.NotificationFullScreenDisplayPeriod;

            // AI
            IsAIEnabled = _reminder.IsAIEnabled;
        }

        [RelayCommand()]
        private void OkButton()
        {
            // General
            _reminder.Name = Name;
            _reminder.Description = Description;

            // Timing
            _reminder.Interval = Interval;
            _reminder.Period = Period;

            // Notification
            _reminder.NotificationType = NotificationType;
            _reminder.FullScreenBackgroundOpacity = FullScreenBackgroundOpacity;

            // Notification : Full Screen
            _reminder.NotificationFullScreenDisplayTime = FullScreenDisplayTime;
            _reminder.NotificationFullScreenDisplayPeriod = FullScreenDisplayPeriod;

            // AI
            _reminder.IsAIEnabled = IsAIEnabled;

            _parentForm.DialogResult = DialogResult.OK;
        }
    }
}
