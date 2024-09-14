using NagMe.IO;
using NagMe.Reminders;
using NagMe.Windows;

namespace NagMe
{
    internal static class Program
    {
        private static SystemTray? _systemTray;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ReminderLoader.Initialize(Path.Combine(PathManager.Current.GetUserConfigurationPath(), "reminders.json"));
            ReminderMonitor.Current.Start();
            ReminderMonitor.Current.ReminderPopped += Current_ReminderPopped;
            Configuration.Configuration.Initialize(Path.Combine(PathManager.Current.GetUserConfigurationPath(), "config.json"));
            _systemTray = new SystemTray("NagMe");

            Application.Run();
        }

        private static void Current_ReminderPopped(object? sender, ReminderPoppedEventArgs e)
        {
            MessageBox.Show($"Reminder {e.Reminder.Name} popped!");
        }
    }
}