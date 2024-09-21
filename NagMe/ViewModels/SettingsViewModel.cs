using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NagMe.Enums;
using NagMe.Forms;
using NagMe.Reminders;
using NagMe.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Timers;

namespace NagMe.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
        private readonly string[] _ignoredProperties = new string[]
        {
            nameof(IsDirty),
            nameof(QueueBindingSource),
            nameof(SelectedReminderQueueItem),
            nameof(Reminders)
        };

        private Form _parentForm;

        private List<ReminderQueueItem> _queueReminders;
        private System.Timers.Timer _queueUpdateTimer;

        [ObservableProperty]
        private bool _startWithWindows;

        [ObservableProperty]
        private bool _aiEnabled;

        [ObservableProperty]
        private string? _openAiApiToken;

        [ObservableProperty]
        private int _aiResourceLifeTime;

        [ObservableProperty]
        private LongIntervalPeriod _aiResourceLifeTimePeriod;

        [ObservableProperty]
        private int _aiResourceAlertTitleLimit;

        [ObservableProperty]
        private int _aiResourceAlertMessageLimit;

        [ObservableProperty]
        private int _aiResourceAlertImageLimit;

        [ObservableProperty]
        private int _aiResourceAlertAudioLimit;

        [ObservableProperty]
        private BindingSource _queueBindingSource;

        [ObservableProperty]
        private ReminderQueueItem? _selectedReminderQueueItem;

        [ObservableProperty]
        private ObservableCollection<Reminder> _reminders = new ObservableCollection<Reminder>();

        [ObservableProperty]
        private ObservableCollection<LongIntervalPeriod> _periods;

        [ObservableProperty]
        private bool _isDirty;

        public SettingsViewModel(Form parentForm)
        {
            _parentForm = parentForm;
            _parentForm.FormClosing += _parentForm_FormClosing1;

            _parentForm.FormClosing += _parentForm_FormClosing;

            _queueReminders = [];
            _queueBindingSource = new BindingSource
            {
                DataSource = _queueReminders
            };

            var periods = Enum.GetNames(typeof(LongIntervalPeriod)).Select(x => Enum.Parse<LongIntervalPeriod>(x)).ToList();
            Periods = new ObservableCollection<LongIntervalPeriod>(periods);

            _queueUpdateTimer = new System.Timers.Timer(new TimeSpan(0, 0, 1));
            _queueUpdateTimer.Elapsed += _queueUpdateTimer_Elapsed;
            _queueUpdateTimer.Start();

            ReadSettings();
            this.PropertyChanged += SettingsViewModel_PropertyChanged;
        }

        private void _parentForm_FormClosing1(object? sender, FormClosingEventArgs e)
        {
            _queueUpdateTimer.Stop();
        }

        private void SettingsViewModel_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            if(_ignoredProperties.Contains(e.PropertyName))
            {
                return;
            }

            // I had to set minimum limits of these controls to 0 to fix a weird bug
            // so in order to prevent 0 from being selected, I am detecting the change
            // here and then forcing to 1 when less than 1.
            switch(e.PropertyName)
            {
                case nameof(AiResourceAlertTitleLimit):
                    {
                        if (AiResourceAlertTitleLimit < 1)
                        {
                            AiResourceAlertTitleLimit = 1;
                        }
                        break;
                    }

                case nameof(AiResourceAlertMessageLimit):
                    {
                        if (AiResourceAlertMessageLimit < 1)
                        {
                            AiResourceAlertMessageLimit = 1;
                        }
                        break;
                    }

                case nameof(AiResourceAlertImageLimit):
                    {
                        if (AiResourceAlertImageLimit < 1)
                        {
                            AiResourceAlertImageLimit = 1;
                        }
                        break;
                    }

                case nameof(AiResourceAlertAudioLimit):
                    {
                        if(AiResourceAlertAudioLimit < 1)
                        {
                            AiResourceAlertAudioLimit = 1;
                        }
                        break;
                    }
            }
            IsDirty = true;
        }

        private void _parentForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            _queueUpdateTimer.Stop();
        }

        private void _queueUpdateTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            UpdateQueue();
        }

        private void UpdateQueue()
        {
            if (_parentForm.InvokeRequired)
            {
                _parentForm.Invoke((MethodInvoker)delegate
                {
                    DoUpdate();
                });
            }
            else
            {
                DoUpdate();
            }
        }

        private void DoUpdate()
        {
            var reset = false;
            var stale = _queueReminders.Where(x => !ReminderLoader.Current.Reminders.Any(y => y == x.Reminder)).ToList();
            while (stale.Count > 0)
            {
                var curStale = stale.First();
                _queueReminders.Remove(curStale);
                stale.Remove(curStale);
                reset = true;
            }

            foreach (var curReminder in ReminderLoader.Current.Reminders)
            {
                var existing = _queueReminders.SingleOrDefault(x => x.Reminder == curReminder);
                if (existing == null)
                {
                    var remaining = curReminder.IsEnabled ? curReminder.Displaying ? "Displaying..." : curReminder.GetRemainingTimeAsTimeSpan().ToString(Constants.Standards.TimeSpanFormat) : "-";
                    var newItem = new ReminderQueueItem(
                        curReminder,
                        remaining,
                        "0");

                    _queueReminders.Add(newItem);
                    reset = true;
                }
                else
                {
                    var remaining = curReminder.IsEnabled ? curReminder.Displaying ? "Displaying..." : curReminder.GetRemainingTimeAsTimeSpan().ToString(Constants.Standards.TimeSpanFormat) : "-";
                    existing.RemainingTime = remaining;
                    existing.IsEnabled = curReminder.IsEnabled;
                    reset = true;
                }
            }

            _queueReminders.Sort(new ReminderComparer());

            if (reset && QueueBindingSource != null)
            {
                QueueBindingSource.ResetBindings(false);
            }
        }

        private void ReadSettings()
        {
            Reminders.Clear();
            foreach (var curReminder in ReminderLoader.Current.Reminders)
            {
                Reminders.Add(curReminder);
            }

            StartWithWindows = StartupManager.Current.StartupWithWindows;

            AiEnabled = Configuration.Configuration.Current.EnableAiFeatures;
            OpenAiApiToken = Configuration.Configuration.Current.OpenAIApiKey;
            AiResourceLifeTime = Configuration.Configuration.Current.AIResourceLifeTime;
            AiResourceLifeTimePeriod = Configuration.Configuration.Current.AIResourceLifeTimePeriod;
            AiResourceAlertTitleLimit = Configuration.Configuration.Current.AIResourceAlertTitleLimit;
            AiResourceAlertMessageLimit = Configuration.Configuration.Current.AIResourceAlertMessageLimit;
            AiResourceAlertImageLimit = Configuration.Configuration.Current.AIResourceAlertImageLimit;
            AiResourceAlertAudioLimit = Configuration.Configuration.Current.AIResourceAlertAudioLimit;

            UpdateQueue();
        }

        private void ApplySettings()
        {
            ReminderLoader.Current.SaveReminders();

            StartupManager.Current.StartupWithWindows = StartWithWindows;

            Configuration.Configuration.Current.EnableAiFeatures = AiEnabled;
            Configuration.Configuration.Current.OpenAIApiKey = OpenAiApiToken;
            Configuration.Configuration.Current.AIResourceLifeTime = AiResourceLifeTime;
            Configuration.Configuration.Current.AIResourceLifeTimePeriod = AiResourceLifeTimePeriod;
            Configuration.Configuration.Current.AIResourceAlertTitleLimit = AiResourceAlertTitleLimit;
            Configuration.Configuration.Current.AIResourceAlertMessageLimit = AiResourceAlertMessageLimit;
            Configuration.Configuration.Current.AIResourceAlertImageLimit = AiResourceAlertImageLimit;
            Configuration.Configuration.Current.AIResourceAlertAudioLimit = AiResourceAlertAudioLimit;
        }

        [RelayCommand]
        private void ApplyButton()
        {
            ApplySettings();
            IsDirty = false;
        }

        [RelayCommand]
        private void OkButton()
        {
            ApplySettings();
            _parentForm.DialogResult = DialogResult.OK;
        }

        [RelayCommand]
        private void CancelButton()
        {
            _parentForm.DialogResult = DialogResult.Cancel;
        }

        [RelayCommand]
        private void AddReminderButton()
        {
            var reminder = new Reminder();
            var reminderEditor = new ReminderEditorDialog(reminder);
            var result = reminderEditor.ShowDialog(_parentForm);
            if (result == DialogResult.OK)
            {
                ReminderLoader.Current.AddReminder(reminder);
                Reminders.Add(reminder);
                UpdateQueue();
                IsDirty = true;
            }
        }

        [RelayCommand]
        private void EditReminderButton()
        {
            if (SelectedReminderQueueItem == null)
            {
                return;
            }

            var original = SelectedReminderQueueItem.Reminder;
            var reminder = SelectedReminderQueueItem.Reminder.Clone();
            var reminderEditor = new ReminderEditorDialog(reminder);
            var result = reminderEditor.ShowDialog(_parentForm);
            if (result == DialogResult.OK)
            {
                if(ReminderLoader.Current.Reminders.Contains(original))
                {
                    ReminderLoader.Current.UpdateReminder(original, reminder);
                    UpdateQueue();
                    IsDirty = true;
                }
            }
        }

        [RelayCommand]
        private void DeleteReminderButton(object selectedReminder)
        {
            if(SelectedReminderQueueItem == null)
            {
                return;
            }

            ReminderLoader.Current.RemoveReminder(SelectedReminderQueueItem.Reminder);
            Reminders.Remove(SelectedReminderQueueItem.Reminder);
            UpdateQueue();
            IsDirty = true;
        }

        [RelayCommand]
        private void ToggleReminderEnabledButton()
        {
            if (SelectedReminderQueueItem == null)
            {
                return;
            }

            if (!SelectedReminderQueueItem.Reminder.IsEnabled)
            {
                SelectedReminderQueueItem.Reminder.Restart();
            }
            SelectedReminderQueueItem.Reminder.IsEnabled = !SelectedReminderQueueItem.Reminder.IsEnabled;
            IsDirty = true;
        }
    }
}
