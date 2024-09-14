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
            StartWithWindowsCheckBox.Checked = startupManager.StartupWithWindows;
        }

        private void ApplySettings()
        {
            var startupManager = StartupManager.Current;
            startupManager.StartupWithWindows = StartWithWindowsCheckBox.Checked;

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

        }
    }
}
