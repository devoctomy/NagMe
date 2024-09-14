using NagMe.Windows;

namespace NagMe
{
    internal static class Program
    {
        private static SystemTray _systemTray;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            _systemTray = new SystemTray("NagMe");

            Application.Run();
        }
    }
}