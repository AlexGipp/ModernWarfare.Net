using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Warzone
{
    public class Metadata
    {
        [JsonProperty("lastUpdated")]
        public LastUpdated LastUpdated { get; set; }

        [JsonProperty("hasPlayedModernWarfare")]
        public bool HasPlayedModernWarfare { get; set; }
    }
}
