using Microsoft.Win32;

namespace NagMe.Windows
{
    public static class ThemeDetector
    {
        // -----------------------------------------------------------------------------
        // This method was generated with assistance from ChatGPT (OpenAI).
        // -----------------------------------------------------------------------------
        public static bool IsDarkModeEnabled()
        {
            const string registryKeyPath = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
            const string registryValueName = "AppsUseLightTheme";

            using (RegistryKey? key = Registry.CurrentUser.OpenSubKey(registryKeyPath))
            {
                if (key != null)
                {
                    object? registryValueObject = key.GetValue(registryValueName);
                    if (registryValueObject != null)
                    {
                        int registryValue = (int)registryValueObject;
                        return registryValue == 0;
                    }
                }
            }

            return false;
        }
    }
}
