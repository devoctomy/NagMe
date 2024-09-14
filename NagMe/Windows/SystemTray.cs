using NagMe.Forms;

namespace NagMe.Windows
{
    public class SystemTray
    {
        public string ToolTip { get; private set; }

        private NotifyIcon _notifyIcon;
        private ContextMenuStrip _contextMenuStrip;

        public SystemTray(string toolTip)
        {
            ToolTip = toolTip;

            _contextMenuStrip = new ContextMenuStrip();
            var settings = new ToolStripMenuItem("Settings", null, OnSettings);
            var exit = new ToolStripMenuItem("Exit", null, OnExit);
            _contextMenuStrip.Items.Add(settings);
            _contextMenuStrip.Items.Add(exit);

            _notifyIcon = new NotifyIcon();
            _notifyIcon.ContextMenuStrip = _contextMenuStrip;
            _notifyIcon.Icon = ThemeDetector.IsDarkModeEnabled() ?
                Resources.LoadIconFromEmbeddedResource("NagMe.Resources.Warning-Shield-24xWhite.ico") :
                Resources.LoadIconFromEmbeddedResource("NagMe.Resources.Warning-Shield-24xBlack.ico");
            _notifyIcon.Visible = true;
        }

        private void OnSettings(object? sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            var result = settingsForm.ShowDialog();
        }

        private void OnExit(object? sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
