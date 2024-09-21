using NagMe.Cryptography;
using NagMe.Enums;
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

        public string? OpenAIApiKey
        {
            get
            {
                if(string.IsNullOrEmpty(_config.OpenAiApiKeyBase64CypherText))
                {
                    return null;
                }

                var stringProtector = new StringProtector("NagMe", "Secure config settings");
                var plaintext = stringProtector.Decrypt(_config.OpenAiApiKeyBase64CypherText);
                return plaintext;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    _config.OpenAiApiKeyBase64CypherText = null;
                    Save();
                    return;
                }

                var stringProtector = new StringProtector("NagMe", "Secure config settings");
                var base64CypherText = stringProtector.Encrypt(value);
                _config.OpenAiApiKeyBase64CypherText = base64CypherText;
                Save();
            }
        }

        public int AIResourceLifeTime
        {
            get
            {
                return _config.AIResourceLifeTime;
            }
            set
            {
                if (_config.AIResourceLifeTime != value)
                {
                    _config.AIResourceLifeTime = value;
                    Save();
                }
            }
        }

        public LongIntervalPeriod AIResourceLifeTimePeriod
        {
            get
            {
                return _config.AIResourceLifeTimePeriod;
            }
            set
            {
                if (_config.AIResourceLifeTimePeriod != value)
                {
                    _config.AIResourceLifeTimePeriod = value;
                    Save();
                }
            }
        }

        public DateTime? LastAIResourceUpdate
        {
            get
            {
                return _config.LastAIResourceUpdate;
            }
            set
            {
                if (_config.LastAIResourceUpdate != value)
                {
                    _config.LastAIResourceUpdate = value;
                    Save();
                }
            }
        }

        public int AIResourceAlertTitleLimit
        {
            get
            {
                return _config.AIResourceAlertTitleLimit;
            }
            set
            {
                if (_config.AIResourceAlertTitleLimit != value)
                {
                    _config.AIResourceAlertTitleLimit = value;
                    Save();
                }
            }
        }

        public int AIResourceAlertMessageLimit
        {
            get
            {
                return _config.AIResourceAlertMessageLimit;
            }
            set
            {
                if (_config.AIResourceAlertMessageLimit != value)
                {
                    _config.AIResourceAlertMessageLimit = value;
                    Save();
                }
            }
        }

        public int AIResourceAlertImageLimit
        {
            get
            {
                return _config.AIResourceAlertImageLimit;
            }
            set
            {
                if (_config.AIResourceAlertImageLimit != value)
                {
                    _config.AIResourceAlertImageLimit = value;
                    Save();
                }
            }
        }

        public int AIResourceAlertAudioLimit
        {
            get
            {
                return _config.AIResourceAlertAudioLimit;
            }
            set
            {
                if (_config.AIResourceAlertAudioLimit != value)
                {
                    _config.AIResourceAlertAudioLimit = value;
                    Save();
                }
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
