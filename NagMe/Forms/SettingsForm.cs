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
            BindControls();
        }

        private void BindControls()
        {
            OkButton.Command = _viewModel.OkButtonCommand;
            CnclButton.Command = _viewModel.CancelButtonCommand;
            ApplyButton.Command = _viewModel.ApplyButtonCommand;
            AddReminderButton.Command = _viewModel.AddReminderButtonCommand;
            EditReminderButton.Command = _viewModel.EditReminderButtonCommand;
            DeleteReminderButton.Command = _viewModel.DeleteReminderButtonCommand;
            ToggleReminderEnabledButton.Command = _viewModel.ToggleReminderEnabledButtonCommand;
            AiEnableCheckBox.DataBindings.Add("Checked", _viewModel, nameof(_viewModel.AiEnabled), false, DataSourceUpdateMode.OnPropertyChanged);
            AiFeaturesPanel.DataBindings.Add("Enabled", _viewModel, nameof(_viewModel.AiEnabled), false, DataSourceUpdateMode.OnPropertyChanged);
            ApplyButton.DataBindings.Add("Enabled", _viewModel, nameof(_viewModel.IsDirty), false, DataSourceUpdateMode.OnPropertyChanged);
            ReminderQueueDataGrid.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.QueueBindingSource), false, DataSourceUpdateMode.OnPropertyChanged);
            ReminderQueueDataGrid.SelectionChanged += ReminderQueueDataGrid_SelectionChanged;
        }

        private void ReminderQueueDataGrid_SelectionChanged(object? sender, EventArgs e)
        {
            if (ReminderQueueDataGrid.SelectedRows.Count > 0)
            {
                var selected = ReminderQueueDataGrid.SelectedRows[0].DataBoundItem as ReminderQueueItem;
                _viewModel.SelectedReminderQueueItem = selected;
            }
        }
    }
}
