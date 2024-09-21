namespace NagMe.IO
{
    // -----------------------------------------------------------------------------
    // This class was generated with assistance from ChatGPT (OpenAI).
    // -----------------------------------------------------------------------------
    public class PathManager
    {
        private readonly string _appName;
        private static PathManager? _current;

        public static PathManager Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new PathManager("NagMe");
                }

                return _current;
            }
        }

        private PathManager(string appName)
        {
            _appName = appName;
            EnsurePathsExist();
        }

        public static string GetUserDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public string GetUserStorageRootPath()
        {
            return Path.Combine(GetUserDocumentsPath(), _appName);
        }

        public string GetUserConfigurationPath()
        {
            return Path.Combine(GetUserStorageRootPath(), "Configuration");
        }

        public string GetUserResourcesPath()
        {
            return Path.Combine(GetUserStorageRootPath(), "Resources");
        }

        public void EnsurePathsExist()
        {
            Directory.CreateDirectory(GetUserStorageRootPath());
            Directory.CreateDirectory(GetUserConfigurationPath());
        }
    }
}
