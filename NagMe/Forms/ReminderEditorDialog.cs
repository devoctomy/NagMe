using NagMe.Reminders;
using NagMe.ViewModels;

namespace NagMe.Forms
{
    public partial class ReminderEditorDialog : Form
    {
        private ReminderEditorViewModel _viewModel;

        public ReminderEditorDialog(Reminder reminder)
        {
            InitializeComponent();
            _viewModel = new ReminderEditorViewModel(
                this,
                reminder);
            DataContext = _viewModel;
            BindControls();
        }

        private void BindControls()
        {
            OkButton.Command = _viewModel.OkButtonCommand;
            GeneralNameTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Name), false, DataSourceUpdateMode.OnPropertyChanged);
            GeneralDescriptionTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Description), false, DataSourceUpdateMode.OnPropertyChanged);
            TimingsIntervalNumericUpDown.DataBindings.Add("Value", _viewModel, nameof(_viewModel.Interval), false, DataSourceUpdateMode.OnPropertyChanged);
            TimingsIntervalPeriod.DataBindings.Add("SelectedItem", _viewModel, nameof(_viewModel.Period), false, DataSourceUpdateMode.OnPropertyChanged);
            TimingsIntervalPeriod.DataSource = _viewModel.Periods;
            NotificationTypeComboBox.DataBindings.Add("SelectedItem", _viewModel, nameof(_viewModel.NotificationType), false, DataSourceUpdateMode.OnPropertyChanged);
            NotificationTypeComboBox.DataSource = _viewModel.NotificationTypes;
        }
    }
}
