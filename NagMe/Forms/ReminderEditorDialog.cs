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
            if(TimingsIntervalPeriod.SelectedIndex == -1)
            {
                TimingsIntervalPeriod.SelectedIndex = 0; // Seconds
            }
        }
    }
}
