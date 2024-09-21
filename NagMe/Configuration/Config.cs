using NagMe.Enums;

namespace NagMe.Configuration
{
    public class Config
    {
        public bool FirstRun { get; set; } = true;
        public bool EnableAiFeatures { get; set; }
        public string? OpenAiApiKeyBase64CypherText { get; set; }
        public int AIResourceLifeTime { get; set; }
        public LongIntervalPeriod AIResourceLifeTimePeriod { get; set; } = LongIntervalPeriod.Days;
        public DateTime? LastAIResourceUpdate { get; set; }
    }
}
