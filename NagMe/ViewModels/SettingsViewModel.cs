using CommunityToolkit.Mvvm.ComponentModel;
using NagMe.Forms;
using NagMe.Reminders;
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
        private BindingSource _queueBindingSource;

        public SettingsViewModel(Form parentForm)
        {
            _parentForm = parentForm;

            _queueReminders = new List<ReminderQueueItem>();
            _queueBindingSource = new BindingSource();
            _queueBindingSource.DataSource = _queueReminders;

            _queueUpdateTimer = new System.Timers.Timer(new TimeSpan(0, 0, 1));
            _queueUpdateTimer.Elapsed += _queueUpdateTimer_Elapsed;
            _queueUpdateTimer.Start();
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
    }
}
