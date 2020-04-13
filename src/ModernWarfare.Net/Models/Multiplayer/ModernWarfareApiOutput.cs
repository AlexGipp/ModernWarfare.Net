using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Multiplayer
{
    public class ModernWarfareApiOutput
    {
        [JsonProperty("data")]
        public Data Data { get; set; }
    }
}
