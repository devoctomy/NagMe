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
        }

        public static string GetUserDocumentsPath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }

        public string GetUserStorageRootPath()
        {
            var dir = Path.Combine(GetUserDocumentsPath(), _appName);
            Directory.CreateDirectory(dir);
            return dir;
        }

        public string GetUserConfigurationPath()
        {
            var dir = Path.Combine(GetUserStorageRootPath(), "Configuration");
            Directory.CreateDirectory(dir);
            return dir;
        }

        public string GetUserResourcesPath()
        {
            var dir = Path.Combine(GetUserStorageRootPath(), "Resources");
            Directory.CreateDirectory(dir);
            return dir;
        }
    }
}
