using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Multiplayer
{
    public class MultiplayerApiOutput
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
