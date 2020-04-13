using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Warzone
{
    public class ModernWarfareApiOutput
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}