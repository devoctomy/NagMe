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
            Configuration.Configuration.Initialize(Path.Combine(PathManager.Current.GetUserConfigurationPath(), "config.json"));
            _systemTray = new SystemTray("NagMe");

            Application.Run();
        }
    }
}