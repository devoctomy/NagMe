using NagMe.Enums;

namespace NagMe.Configuration
{
    public class Config
    {
        public bool FirstRun { get; set; } = true;
        public bool EnableAiFeatures { get; set; }
        public string? OpenAiApiKeyBase64CypherText { get; set; }
        public int AIResourceLifeTime { get; set; } = 7;
        public LongIntervalPeriod AIResourceLifeTimePeriod { get; set; } = LongIntervalPeriod.Days;
        public DateTime? LastAIResourceUpdate { get; set; }
        public int AIResourceAlertTitleLimit { get; set; } = 10;
        public int AIResourceAlertMessageLimit { get; set; } = 10;
        public int AIResourceAlertImageLimit { get; set; } = 10;
        public int AIResourceAlertAudioLimit { get; set; } = 10;
    }
}
