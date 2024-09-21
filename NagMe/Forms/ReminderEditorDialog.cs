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

            // General
            GeneralNameTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Name), false, DataSourceUpdateMode.OnPropertyChanged);
            GeneralDescriptionTextBox.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Description), false, DataSourceUpdateMode.OnPropertyChanged);
            
            // Timing
            TimingsIntervalNumericUpDown.DataBindings.Add("Value", _viewModel, nameof(_viewModel.Interval), false, DataSourceUpdateMode.OnPropertyChanged);
            TimingsIntervalPeriodComboBox.DataBindings.Add("SelectedItem", _viewModel, nameof(_viewModel.Period), false, DataSourceUpdateMode.OnPropertyChanged);
            TimingsIntervalPeriodComboBox.SelectionChangeCommitted += (s, e) =>
            {
                TimingsIntervalPeriodComboBox.DataBindings["SelectedItem"].WriteValue();
            };
            TimingsIntervalPeriodComboBox.DataSource = _viewModel.Periods;

            // Notification
            NotificationTypeComboBox.DataSource = _viewModel.NotificationTypes;
            NotificationTypeComboBox.DataBindings.Add("SelectedItem", _viewModel, nameof(_viewModel.NotificationType), false, DataSourceUpdateMode.OnPropertyChanged);
            NotificationTypeComboBox.SelectionChangeCommitted += (s, e) =>
            {
                NotificationTypeComboBox.DataBindings["SelectedItem"].WriteValue();
            };
            NotificationSettingsTabs.DataBindings.Add("SelectedIndex", _viewModel, nameof(_viewModel.SelectedNotificationTabIndex), false, DataSourceUpdateMode.OnPropertyChanged);
            NotificationSettingsTabs.Appearance = TabAppearance.FlatButtons;
            NotificationSettingsTabs.ItemSize = new Size(0, 1);
            NotificationSettingsTabs.SizeMode = TabSizeMode.Fixed;
            _viewModel.SelectedNotificationTabIndex = (int)_viewModel.NotificationType - 1;

            // Notification: Full Screen
            NotificationFullScreenDisplayTimeNumericUpDown.DataBindings.Add("Value", _viewModel, nameof(_viewModel.FullScreenDisplayTime), false, DataSourceUpdateMode.OnPropertyChanged);
            NotificationFullScreenBackgroundOpacityTrackbar.DataBindings.Add("Value", _viewModel, nameof(_viewModel.FullScreenBackgroundOpacity), false, DataSourceUpdateMode.OnPropertyChanged);
            NotificationFullScreenDisplayTimePeriodComboBox.DataSource = _viewModel.Periods;
            NotificationFullScreenDisplayTimePeriodComboBox.DataBindings.Add("SelectedItem", _viewModel, nameof(_viewModel.FullScreenDisplayPeriod), false, DataSourceUpdateMode.OnPropertyChanged);
            NotificationFullScreenDisplayTimePeriodComboBox.SelectionChangeCommitted += (s, e) =>
            {
                NotificationFullScreenDisplayTimePeriodComboBox.DataBindings["SelectedItem"].WriteValue();
            };

            // AI Tab
            AIEnabledCheckBox.DataBindings.Add("Checked", _viewModel, nameof(_viewModel.IsAIEnabled), false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
