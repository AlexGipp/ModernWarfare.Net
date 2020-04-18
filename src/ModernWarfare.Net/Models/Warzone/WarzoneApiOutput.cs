using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Warzone
{
    public class WarzoneApiOutput
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}