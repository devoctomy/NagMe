using NagMe.Reminders;
using NagMe.Windows;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Timers;

namespace NagMe.Forms
{
    public partial class SettingsForm : Form
    {
        private List<ReminderQueueItem> _queueReminders = new List<ReminderQueueItem>();
        private System.Timers.Timer _queueUpdateTimer;
        private BindingSource _queueBindingSource;

        public SettingsForm()
        {
            InitializeComponent();
            ReadSettings();

            _queueBindingSource = new BindingSource();
            _queueBindingSource.DataSource = _queueReminders;
            ReminderQueueDataGrid.DataSource = _queueBindingSource;

            _queueUpdateTimer = new System.Timers.Timer(new TimeSpan(0, 0, 1));
            _queueUpdateTimer.Elapsed += _queueUpdateTimer_Elapsed;
            _queueUpdateTimer.Start();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _queueUpdateTimer.Stop();
        }

        private void _queueUpdateTimer_Elapsed(object? sender, ElapsedEventArgs e)
        {
            UpdateQueue();
        }

        private void ReadSettings()
        {
            var startupManager = StartupManager.Current;
            SystemStartWithWindowsCheckBox.Checked = startupManager.StartupWithWindows;

            RemindersCheckedListBox.Items.AddRange(new ListBox.ObjectCollection(RemindersCheckedListBox, [.. ReminderLoader.Current.Reminders]));
            for (int i = 0; i < RemindersCheckedListBox.Items.Count; i++)
            {
                RemindersCheckedListBox.SetItemChecked(i, ReminderLoader.Current.Reminders[i].IsEnabled);
            }

            AiEnableCheckBox.Checked = Configuration.Configuration.Current.EnableAiFeatures;
            AiOpenAiApiTokenTextBox.Text = Configuration.Configuration.Current.OpenAIApiToken;

            UpdateQueue();
        }

        private void ApplySettings()
        {
            var startupManager = StartupManager.Current;
            startupManager.StartupWithWindows = SystemStartWithWindowsCheckBox.Checked;

            if (ReminderLoader.Current.IsDirty)
            {
                ReminderLoader.Current.SaveReminders();
            }

            Configuration.Configuration.Current.EnableAiFeatures = AiEnableCheckBox.Checked;
            Configuration.Configuration.Current.OpenAIApiToken = AiOpenAiApiTokenTextBox.Text;

            ApplyButton.Enabled = false;
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ApplySettings();
            DialogResult = DialogResult.OK;
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void DeleteReminderButton_Click(object sender, EventArgs e)
        {
            if (RemindersCheckedListBox.SelectedItem is Reminder reminder)
            {
                RemindersCheckedListBox.Items.Remove(reminder);
                ReminderLoader.Current.RemoveReminder(reminder);
                UpdateQueue();
                ApplyButton.Enabled = true;
            }
        }

        private void AddReminderButton_Click(object sender, EventArgs e)
        {
            var reminder = new Reminder();
            var reminderEditor = new ReminderEditorDialog(reminder);
            var result = reminderEditor.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                ReminderLoader.Current.AddReminder(reminder);
                RemindersCheckedListBox.Items.Add(reminder);
                UpdateQueue();
                ApplyButton.Enabled = true;
            }
        }

        private void RemindersCheckedListBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var isChecked = RemindersCheckedListBox.CheckedItems.Contains(RemindersCheckedListBox.SelectedItem);
            var selectedReminder = RemindersCheckedListBox.SelectedItem as Reminder;
            if (selectedReminder == null)
            {
                return;
            }

            if (selectedReminder.IsEnabled != isChecked)
            {
                selectedReminder.Restart();
                ReminderLoader.Current.SetReminderEnabledState(selectedReminder, isChecked);
                UpdateQueue();
                ApplyButton.Enabled = true;
            }
        }

        private void AiEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AiFeaturesPanel.Enabled = AiEnableCheckBox.Checked;
        }

        private void UpdateQueue()
        {
            DoUpdate();
            //if (this.InvokeRequired)
            //{
            //    this.Invoke((MethodInvoker)delegate
            //    {
            //        DoUpdate();
            //    });
            //}
            //else
            //{
            //    DoUpdate();
            //}
        }

        private void DoUpdate()
        {
            var reset = false;
            var stale = _queueReminders.Where(x => !ReminderLoader.Current.Reminders.Any(y => y.Id == x.Id)).ToList();
            while (stale.Count > 0)
            {
                var curStale = stale.First();
                _queueReminders.Remove(curStale);
                stale.Remove(curStale);
                reset = true;
            }

            foreach (var curReminder in ReminderLoader.Current.Reminders)
            {
                var existing = _queueReminders.SingleOrDefault(x => x.Id == curReminder.Id);
                if (existing == null)
                {
                    var remaining = curReminder.IsEnabled ? curReminder.GetRemainingTimeAsTimeSpan().ToString(Constants.Standards.TimeSpanFormat) : "-";
                    var newItem = new ReminderQueueItem(
                        curReminder,
                        curReminder.Id,
                        curReminder.Name,
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

            if (reset && _queueBindingSource != null)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        _queueBindingSource.ResetBindings(false);
                    });
                }
                else
                {
                    _queueBindingSource.ResetBindings(false);
                }
            }
        }
    }
}
