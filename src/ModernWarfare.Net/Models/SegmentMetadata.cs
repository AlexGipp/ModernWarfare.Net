using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Models
{
    public class SegmentMetadata
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
