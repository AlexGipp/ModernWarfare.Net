using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Multiplayer
{
    public class Data
    {
        [JsonProperty("platformInfo")]
        public PlatformInfo PlatformInfo { get; set; }

        [JsonProperty("userInfo")]
        public UserInfo UserInfo { get; set; }

        [JsonProperty("metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("segments")]
        public Segment[] Segments { get; set; }

        [JsonProperty("availableSegments")]
        public object[] AvailableSegments { get; set; }

        [JsonProperty("expiryDate")]
        public DateTimeOffset ExpiryDate { get; set; }
    }
}
