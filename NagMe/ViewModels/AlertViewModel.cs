using CommunityToolkit.Mvvm.ComponentModel;
using NagMe.Reminders;
using System.Timers;

namespace NagMe.ViewModels
{
    public partial class AlertViewModel : ObservableObject
    {
        private Form _parentForm;
        private System.Timers.Timer _autoClose;

        [ObservableProperty]
        private string _title;

        [ObservableProperty]
        private string _message;

        public AlertViewModel(
            Form parentForm,
            Reminder reminder)
        {
            _parentForm = parentForm;
            _title = reminder.Name;
            _message = reminder.Description;

            _autoClose = new System.Timers.Timer(new TimeSpan(0, 0, 10)); // !!! Need a property for this
            _autoClose.Elapsed += _autoClose_Elapsed;
            _autoClose.Start();

        }

        private void _autoClose_Elapsed(object? sender, ElapsedEventArgs e)
        {
            _autoClose.Stop();
            _parentForm.Invoke(new Action(() => _parentForm.Close()));
        }
    }
}
