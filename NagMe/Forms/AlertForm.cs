using NagMe.ViewModels;

namespace NagMe.Forms
{
    public partial class AlertForm : Form
    {
        private readonly AlertViewModel _viewModel;

        public AlertForm(Reminders.Reminder reminder)
        {
            InitializeComponent();

            _viewModel = new AlertViewModel(
                this,
                reminder);
            BindControls();
        }

        private void BindControls()
        {
            TitleLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Title), false, DataSourceUpdateMode.OnPropertyChanged);
            MessageLabel.DataBindings.Add("Text", _viewModel, nameof(_viewModel.Message), false, DataSourceUpdateMode.OnPropertyChanged);
        }
    }
}
