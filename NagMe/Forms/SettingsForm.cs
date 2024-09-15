using NagMe.Reminders;
using NagMe.ViewModels;

namespace NagMe.Forms
{
    public partial class SettingsForm : Form
    {
        private SettingsViewModel _viewModel;

        public SettingsForm()
        {
            InitializeComponent();

            _viewModel = new SettingsViewModel(this);
            DisplayReminders();
            _viewModel.Reminders.CollectionChanged += Reminders_CollectionChanged;

            BindControls();
        }

        private void DisplayReminders()
        {
            foreach (var reminder in _viewModel.Reminders)
            {
                RemindersCheckedListBox.Items.Add(reminder);
                if (reminder.IsEnabled)
                {
                    var index = RemindersCheckedListBox.Items.IndexOf(reminder);
                    RemindersCheckedListBox.SetItemCheckState(index, CheckState.Checked);
                }
            }
        }

        private void Reminders_CollectionChanged(object? sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                    {
                        foreach (Reminder curNewItem in e.NewItems!)
                        {
                            RemindersCheckedListBox.Items.Add(curNewItem);
                            if (curNewItem.IsEnabled)
                            {
                                var index = RemindersCheckedListBox.Items.IndexOf(curNewItem);
                                RemindersCheckedListBox.SetItemCheckState(index, CheckState.Checked);
                            }
                        }

                        break;
                    }

                case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                    {
                        foreach (Reminder curNewItem in e.OldItems!)
                        {
                            RemindersCheckedListBox.Items.Remove(curNewItem);
                        }

                        break;
                    }
            }
        }

        private void BindControls()
        {
            OkButton.Command = _viewModel.OkButtonCommand;
            CnclButton.Command = _viewModel.CancelButtonCommand;
            ApplyButton.Command = _viewModel.ApplyButtonCommand;
            AddReminderButton.Command = _viewModel.AddReminderButtonCommand;
            DeleteReminderButton.Command = _viewModel.DeleteReminderButtonCommand;
            ApplyButton.DataBindings.Add("Enabled", _viewModel, nameof(_viewModel.IsDirty), false, DataSourceUpdateMode.OnPropertyChanged);
            RemindersCheckedListBox.DataBindings.Add("SelectedItem", _viewModel, nameof(_viewModel.SelectedReminder), false, DataSourceUpdateMode.OnPropertyChanged);
            ReminderQueueDataGrid.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.QueueBindingSource), false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AiEnableCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            AiFeaturesPanel.Enabled = AiEnableCheckBox.Checked;
        }

        private void RemindersCheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            var reminder = _viewModel.Reminders[e.Index];
            reminder.IsEnabled = e.NewValue == CheckState.Checked;
        }
    }
}
