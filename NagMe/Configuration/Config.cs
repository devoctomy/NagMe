namespace NagMe.Configuration
{
    public class Config
    {
        public bool EnableAiFeatures { get; set; } = false;
        public string? OpenAiApiTokenBase64CypherText { get; set; } = null;
    }
}
