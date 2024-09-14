using NagMe.IO;
using NagMe.Reminders;
using NagMe.Windows;

namespace NagMe
{
    internal static class Program
    {
        private static ReminderLoader? _reminderLoader;
        private static SystemTray? _systemTray;

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            _reminderLoader = ReminderLoader.Initialize(Path.Combine(PathManager.Current.GetUserConfigurationPath(), "reminders.json"));
            _systemTray = new SystemTray("NagMe");

            Application.Run();
        }
    }
}