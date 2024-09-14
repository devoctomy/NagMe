using NagMe.Reminders;
using NagMe.Windows;

namespace NagMe.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            ReadSettings();
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
                ApplyButton.Enabled = true;
            }
        }

        private void AddReminderButton_Click(object sender, EventArgs e)
        {
            var reminderEditor = new ReminderEditorDialog();
            var result = reminderEditor.ShowDialog(this);
            if (result == DialogResult.OK)
            {
                ReminderLoader.Current.AddReminder(reminderEditor.Reminder);
                RemindersCheckedListBox.Items.Add(reminderEditor.Reminder);
                RemindersCheckedListBox.SetItemCheckState(RemindersCheckedListBox.Items.Count - 1, CheckState.Checked);
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
                ReminderLoader.Current.SetReminderEnabledState(selectedReminder, isChecked);
                ApplyButton.Enabled = true;
            }
        }

        private void AiEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AiFeaturesPanel.Enabled = AiEnableCheckBox.Checked;
        }
    }
}
