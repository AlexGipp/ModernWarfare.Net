using System;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Multiplayer
{
    public class Segment
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("metadata")]
        public SegmentMetadata Metadata { get; set; }

        [JsonProperty("expiryDate")]
        public DateTimeOffset ExpiryDate { get; set; }

        [JsonProperty("stats")]
        public MultiplayerStats Stats { get; set; }
    }
}