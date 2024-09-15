using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using NagMe.Forms;
using NagMe.Reminders;
using NagMe.Windows;
using System.Collections.ObjectModel;
using System.Timers;

namespace NagMe.ViewModels
{
    public partial class SettingsViewModel : ObservableObject
    {
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
        private BindingSource _queueBindingSource;

        [ObservableProperty]
        private Reminder? _selectedReminder;

        [ObservableProperty]
        private ObservableCollection<Reminder> _reminders = new ObservableCollection<Reminder>();

        [ObservableProperty]
        private bool _isDirty;

        public SettingsViewModel(Form parentForm)
        {
            _parentForm = parentForm;
            _parentForm.FormClosing += _parentForm_FormClosing;

            _queueReminders = [];
            _queueBindingSource = new BindingSource
            {
                DataSource = _queueReminders
            };

            _queueUpdateTimer = new System.Timers.Timer(new TimeSpan(0, 0, 1));
            _queueUpdateTimer.Elapsed += _queueUpdateTimer_Elapsed;
            _queueUpdateTimer.Start();

            ReadSettings();
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
                    var remaining = curReminder.IsEnabled ? curReminder.GetRemainingTimeAsTimeSpan().ToString(Constants.Standards.TimeSpanFormat) : "-";
                    var newItem = new ReminderQueueItem(
                        curReminder,
                        remaining,
                        "0");

                    _queueReminders.Add(newItem);
                    reset = true;
                }
                else
                {
                    var remaining = curReminder.IsEnabled ? curReminder.GetRemainingTimeAsTimeSpan().ToString(Constants.Standards.TimeSpanFormat) : "-";
                    existing.RemainingTime = remaining;
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
            var startupManager = StartupManager.Current;
            StartWithWindows = startupManager.StartupWithWindows;

            Reminders.Clear();
            foreach (var curReminder in ReminderLoader.Current.Reminders)
            {
                Reminders.Add(curReminder);
            }

            AiEnabled = Configuration.Configuration.Current.EnableAiFeatures;
            OpenAiApiToken = Configuration.Configuration.Current.OpenAIApiToken;

            UpdateQueue();
        }

        private void ApplySettings()
        {
            var startupManager = StartupManager.Current;
            startupManager.StartupWithWindows = StartWithWindows;

            if (ReminderLoader.Current.IsDirty)
            {
                ReminderLoader.Current.SaveReminders();
            }

            Configuration.Configuration.Current.EnableAiFeatures = AiEnabled;
            Configuration.Configuration.Current.OpenAIApiToken = OpenAiApiToken;

            // Enable apply button
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
        private void DeleteReminderButton(object selectedReminder)
        {
            if(SelectedReminder == null)
            {
                return;
            }

            ReminderLoader.Current.RemoveReminder(SelectedReminder);
            Reminders.Remove(SelectedReminder);
            UpdateQueue();
            IsDirty = true;
        }
    }
}
