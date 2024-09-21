namespace NagMe.Reminders
{
    public class ReminderMonitor
    {
        public event EventHandler<ReminderPoppedEventArgs>? ReminderPopped;

        private static ReminderMonitor? _current = null;
        private System.Timers.Timer? _updateTimer;

        public static ReminderMonitor Current
        {
            get
            {
                if(_current == null)
                {
                    _current = new ReminderMonitor();
                }

                return _current;
            }
        }

        public void Start()
        {
            _updateTimer = new System.Timers.Timer(new TimeSpan(0, 0, 1));
            _updateTimer.Elapsed += _updateTimer_Elapsed;
            _updateTimer.Start();
        }

        public void Stop()
        {
            if(_updateTimer == null)
            {
                return;
            }

            _updateTimer.Stop();
        }

        private void _updateTimer_Elapsed(
            object? sender,
            System.Timers.ElapsedEventArgs e)
        {
            CheckReminders();
        }

        private void CheckReminders()
        {
            foreach (var curReminder in ReminderLoader.Current.Reminders.Where(x => x.IsEnabled && !x.Displaying))
            {
                var remainingTime = curReminder.GetRemainingTimeAsTimeSpan();
                if(remainingTime.TotalSeconds <= 0)
                {
                    curReminder.Displaying = true;
                    ReminderPopped?.Invoke(this, new ReminderPoppedEventArgs(curReminder, DateTime.Now));
                }
            }
        }
    }
}
