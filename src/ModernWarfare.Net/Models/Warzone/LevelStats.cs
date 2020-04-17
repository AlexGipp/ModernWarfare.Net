using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Warzone
{
    public class LevelStats
    {
        [JsonProperty("percentile")]
        public double Percentile { get; set; }
        [JsonProperty("displayName")]
        public string DisplayName { get; set; }
        [JsonProperty("displayCategory")]
        public string DisplayCategory { get; set; }
        [JsonProperty("category")]
        public string Category { get; set; }
        [JsonProperty("metaData")]
        public Models.Metadata MetaData { get; set; }
        [JsonProperty("value")]
        public double Value { get; set; }
        [JsonProperty("displayValue")]
        public string DisplayValue { get; set; }
        [JsonProperty("displayType")]
        public string DisplayType { get; set; }
    }
}
