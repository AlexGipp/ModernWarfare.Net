using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Models
{
    public class LastUpdated
    {
        [JsonProperty("value")]
        public object Value { get; set; }

        [JsonProperty("displayValue")]
        public object DisplayValue { get; set; }
    }
}
