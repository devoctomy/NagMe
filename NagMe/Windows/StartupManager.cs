﻿using Microsoft.Win32;

namespace NagMe.Windows
{
    // -----------------------------------------------------------------------------
    // This class was generated with assistance from ChatGPT (OpenAI).
    // -----------------------------------------------------------------------------
    public class StartupManager
    {
        private const string RegistryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Run";

        private readonly string _appName;
        private readonly string _appPath;
        private static StartupManager? _current = null;

        public static StartupManager Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new StartupManager("NagMe");
                }

                return _current;
            }
        }

        private StartupManager(string appName)
        {
            _appName = appName;
            _appPath = Path.Combine(AppContext.BaseDirectory, "NagMe.exe");
        }

        public bool StartupWithWindows
        {
            get
            {
                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, false))
                {
                    if (key == null)
                    {
                        return false;
                    }

                    object? value = key.GetValue(_appName);
                    return value != null && value.ToString() == _appPath;
                }
            }
            set
            {
                using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(RegistryKeyPath, true))
                {
                    if (key == null)
                    {
                        throw new InvalidOperationException("Unable to open registry key.");
                    }

                    if (value)
                    {
                        key.SetValue(_appName, _appPath);
                    }
                    else
                    {
                        if (key.GetValue(_appName) != null)
                        {
                            key.DeleteValue(_appName);
                        }
                    }
                }
            }
        }
    }

}
