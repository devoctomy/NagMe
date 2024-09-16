using NagMe.Forms;
using NagMe.IO;
using NagMe.Reminders;
using NagMe.ViewModels;
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

            if(Configuration.Configuration.Current.FirstRun)
            {
                // Display first run wizard here
                Configuration.Configuration.Current.FirstRun = false;
            }

            Application.Run();
        }

        private static void Current_ReminderPopped(object? sender, ReminderPoppedEventArgs e)
        {
            switch (e.Reminder.NotificationType)
            {
                case Enums.NotificationType.MessageBox:
                    {
                        MessageBox.Show(e.Reminder.Description, e.Reminder.Name, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

                        break;
                    }

                case Enums.NotificationType.Toast:
                    {
                        // pop up toast notification here

                        break;
                    }

                case Enums.NotificationType.FullScreen:
                    {
                        foreach(var curScreen in Screen.AllScreens)
                        {
                            var alertForm = new AlertForm(e.Reminder)
                            {
                                StartPosition = FormStartPosition.Manual,
                                Location = curScreen.Bounds.Location,
                                Size = curScreen.Bounds.Size
                            };
                            alertForm.Show();
                        }

                        break;
                    }
            }
        }
    }
}