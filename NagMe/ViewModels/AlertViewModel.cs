using CommunityToolkit.Mvvm.ComponentModel;
using NagMe.Extensions;
using NagMe.Reminders;
using System.Timers;

namespace NagMe.ViewModels
{
    public partial class AlertViewModel : ObservableObject
    {
        private Form _parentForm;
        private System.Timers.Timer? _autoClose = null;

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

            _autoClose = new System.Timers.Timer(reminder.NotificationFullScreenDisplayPeriod.CreateTimeSpan(reminder.NotificationFullScreenDisplayTime));
            _autoClose.Elapsed += _autoClose_Elapsed;
            _autoClose.Start();
        }

        private void _autoClose_Elapsed(object? sender, ElapsedEventArgs e)
        {
            var timer = sender as System.Timers.Timer;
            if(timer == null && _autoClose != null)
            {
                _autoClose.Stop();
            }


            if (_parentForm.InvokeRequired)
            {
                _parentForm.Invoke((MethodInvoker)delegate
                {
                    _parentForm.Close();
                });
            }
            else
            {
                _parentForm.Close();
            }
        }
    }
}
