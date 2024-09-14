using NagMe.Cryptography;
using System.Text.Json;

namespace NagMe.Configuration
{
    public class Configuration
    {
        private static Configuration? _current;
        private Config _config = new();
        private string? _configPath = null;

        public static Configuration Current
        {
            get
            {
                ArgumentNullException.ThrowIfNull(_current);
                return _current;
            }
        }

        public static Configuration Initialize(string path)
        {
            _current = new Configuration(path);
            return _current;
        }

        private Configuration(string path)
        {
            _configPath = path;
            Load();
        }

        public bool FirstRun
        {
            get
            {
                return _config.FirstRun;
            }
            set
            {
                if (_config.FirstRun != value)
                {
                    _config.FirstRun = value;
                    Save();
                }
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
                if(string.IsNullOrEmpty(_config.OpenAiApiTokenBase64CypherText))
                {
                    return null;
                }

                var stringProtector = new StringProtector("NagMe", "Secure config settings");
                var plaintext = stringProtector.Decrypt(_config.OpenAiApiTokenBase64CypherText);
                return plaintext;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _config.OpenAiApiTokenBase64CypherText = null;
                    Save();
                    return;
                }

                var stringProtector = new StringProtector("NagMe", "Secure config settings");
                var base64CypherText = stringProtector.Encrypt(value);
                _config.OpenAiApiTokenBase64CypherText = base64CypherText;
                Save();
            }
        }

        private void Save()
        {
            ArgumentNullException.ThrowIfNull(_configPath);

            var configJsonRaw = JsonSerializer.Serialize(_config);
            File.WriteAllText(_configPath, configJsonRaw);
        }

        private void Load()
        {
            ArgumentNullException.ThrowIfNull(_configPath);

            if (!File.Exists(_configPath))
            {
                Save();
                return;
            }

            var configJsonRaw = File.ReadAllText(_configPath);
            var config = JsonSerializer.Deserialize<Config>(configJsonRaw);
            if (config != null)
            {
                _config = config;
            }
        }
    }
}
