using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Multiplayer
{
    public class Metadata
    {
        [JsonProperty("lastUpdated")]
        public LastUpdated LastUpdated { get; set; }
    }
}
