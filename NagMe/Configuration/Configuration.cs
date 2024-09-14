using NagMe.Cryptography;
using NagMe.IO;
using System.Text.Json;

namespace NagMe.Configuration
{
    public class Configuration
    {
        private static Configuration? _current;
        private Config _config = new();

        public static Configuration Current
        {
            get
            {
                if (_current == null)
                {
                    _current = new Configuration();
                    _current.Load();
                }

                return _current;
            }
        }

        public bool EnableAiFeatures
        {
            get
            {
                return _config.EnableAiFeatures;
            }
            set
            {
                if (_config.EnableAiFeatures != value)
                {
                    _config.EnableAiFeatures = value;
                    Save();
                }
            }
        }

        public string? OpenAIApiToken
        {
            get
            {
                return CredentialManager.Current.GetCredential("NagMe.OpenAIApiToken");
            }
            set
            {
                var token = CredentialManager.Current.GetCredential("NagMe.OpenAIApiToken");

                if (token != value)
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        CredentialManager.Current.RemoveCredential("NagMe.OpenAIApiToken");
                        return;
                    }

                    CredentialManager.Current.SetCredential("NagMe.OpenAIApiToken", value);
                }
            }
        }

        private void Save()
        {
            var configJsonRaw = JsonSerializer.Serialize(_config);
            File.WriteAllText(Path.Combine(PathManager.Current.GetUserConfigurationPath(), "config.json"), configJsonRaw);
        }

        private void Load()
        {
            var configPath = Path.Combine(PathManager.Current.GetUserConfigurationPath(), "config.json");
            if (!File.Exists(configPath))
            {
                return;
            }

            var configJsonRaw = File.ReadAllText(Path.Combine(PathManager.Current.GetUserConfigurationPath(), "config.json"));
            var config = JsonSerializer.Deserialize<Config>(configJsonRaw);
            if(config != null)
            {
                _config = config;
            }
        }

    }
}
