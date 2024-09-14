using NagMe.Enums;
using NagMe.Reminders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NagMe.Forms
{
    public partial class ReminderEditorDialog : Form
    {
        private Reminder _reminder = new Reminder();

        public Reminder Reminder => _reminder;

        public ReminderEditorDialog()
        {
            InitializeComponent();
            EnumeratePeriods();
            ReadReminder();
        }

        public ReminderEditorDialog(Reminder reminder)
        {
            InitializeComponent();
            EnumeratePeriods();
            _reminder = reminder;
            ReadReminder();
        }

        private void ReadReminder()
        {
            GeneralNameTextBox.Text = _reminder.Name;
            GeneralDescriptionTextBox.Text = _reminder.Description;
            TimingsIntervalNumericUpDown.Value = _reminder.Interval;
            TimingsIntervalPeriod.Text = _reminder.Period.ToString();
            ReminderEditorTabs.SelectedTab = GeneralTab;
        }

        private void EnumeratePeriods()
        {
            var periods = Enum.GetNames(typeof(IntervalPeriod));
            TimingsIntervalPeriod.Items.AddRange(periods);
        }

        private void TimingsIntervalPeriod_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TimingsIntervalPeriod.SelectedIndex == -1)
            {
                TimingsIntervalPeriod.SelectedIndex = 0; // Seconds
            }
        }

        private void UpdateReminder()
        {
            _reminder.Name = GeneralNameTextBox.Text;
            _reminder.Description = GeneralDescriptionTextBox.Text;
            _reminder.Interval = (int)TimingsIntervalNumericUpDown.Value;
            _reminder.Period = Enum.Parse<IntervalPeriod>(TimingsIntervalPeriod.Text);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            UpdateReminder();
            DialogResult = DialogResult.OK;
        }
    }
}
