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
            ReminderQueueDataGrid.DataBindings.Add("DataSource", _viewModel, nameof(_viewModel.QueueBindingSource), false, DataSourceUpdateMode.OnPropertyChanged);
            ReminderQueueDataGrid.SelectionChanged += ReminderQueueDataGrid_SelectionChanged;
            AddReminderButton.Command = _viewModel.AddReminderButtonCommand;
            EditReminderButton.Command = _viewModel.EditReminderButtonCommand;
            DeleteReminderButton.Command = _viewModel.DeleteReminderButtonCommand;
            ToggleReminderEnabledButton.Command = _viewModel.ToggleReminderEnabledButtonCommand;

            SystemStartWithWindowsCheckBox.DataBindings.Add("Checked", _viewModel, nameof(_viewModel.StartWithWindows), false, DataSourceUpdateMode.OnPropertyChanged);

            AiEnableCheckBox.DataBindings.Add("Checked", _viewModel, nameof(_viewModel.AiEnabled), false, DataSourceUpdateMode.OnPropertyChanged);
            AiFeaturesPanel.DataBindings.Add("Enabled", _viewModel, nameof(_viewModel.AiEnabled), false, DataSourceUpdateMode.OnPropertyChanged);
            AIResourceLifeTimeNumericUpDown.DataBindings.Add("Value", _viewModel, nameof(_viewModel.AiResourceLifeTime), false, DataSourceUpdateMode.OnPropertyChanged);

            AIResourceLifeTimePeriodComboBox.DataBindings.Add("SelectedItem", _viewModel, nameof(_viewModel.AiResourceLifeTimePeriod), false, DataSourceUpdateMode.OnPropertyChanged);
            AIResourceLifeTimePeriodComboBox.SelectionChangeCommitted += (s, e) =>
            {
                AIResourceLifeTimePeriodComboBox.DataBindings["SelectedItem"].WriteValue();
            };
            AIResourceLifeTimePeriodComboBox.DataSource = _viewModel.Periods;

            AIAlertTitlesNumericUpDown.DataBindings.Add("Value", _viewModel, nameof(_viewModel.AiResourceAlertTitleLimit), false, DataSourceUpdateMode.OnPropertyChanged);
            AIAlertMessagesNumericUpDown.DataBindings.Add("Value", _viewModel, nameof(_viewModel.AiResourceAlertMessageLimit), false, DataSourceUpdateMode.OnPropertyChanged);
            AIAlertImagesNumericUpDown.DataBindings.Add("Value", _viewModel, nameof(_viewModel.AiResourceAlertImageLimit), false, DataSourceUpdateMode.OnPropertyChanged);
            AIAlertAudioNumericUpDown.DataBindings.Add("Value", _viewModel, nameof(_viewModel.AiResourceAlertAudioLimit), false, DataSourceUpdateMode.OnPropertyChanged);

            OkButton.Command = _viewModel.OkButtonCommand;
            CnclButton.Command = _viewModel.CancelButtonCommand;
            ApplyButton.Command = _viewModel.ApplyButtonCommand;
            ApplyButton.DataBindings.Add("Enabled", _viewModel, nameof(_viewModel.IsDirty), false, DataSourceUpdateMode.OnPropertyChanged);
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
