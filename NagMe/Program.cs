using NagMe.Forms;
using NagMe.IO;
using NagMe.Reminders;
using NagMe.Windows;
using System.Collections.Concurrent;

namespace NagMe
{
    internal static class Program
    {
        private static SystemTray? _systemTray;
        private static List<Form> _alertForms = new List<Form>();

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
                            Task.Run(async () =>
                            {
                                await DisplayFullScreenAlertForm(curScreen, e.Reminder);
                            });
                        }

                        break;
                    }
            }
        }

        private static async Task DisplayFullScreenAlertForm(
            Screen screen,
            Reminder reminder)
        {
            await Task.Yield();
            using var alertForm = new AlertForm(reminder)
            {
                StartPosition = FormStartPosition.Manual,
                Location = screen.Bounds.Location,
                Size = screen.Bounds.Size
            };
            alertForm.ShowDialog();
        }

        private static void AlertForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            var alertForm = sender as Form;
            if(alertForm == null)
            {
                return;
            }

            lock (_alertForms)
            {
                _alertForms.Remove(alertForm);
                alertForm.Dispose();
            }
        }
    }
}