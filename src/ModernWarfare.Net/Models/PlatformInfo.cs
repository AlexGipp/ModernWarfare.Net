using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Models
{
    public class PlatformInfo
    {
        [JsonProperty("platformSlug")]
        public string PlatformSlug { get; set; }

        [JsonProperty("platformUserId")]
        public object PlatformUserId { get; set; }

        [JsonProperty("platformUserHandle")]
        public string PlatformUserHandle { get; set; }

        [JsonProperty("platformUserIdentifier")]
        public string PlatformUserIdentifier { get; set; }

        [JsonProperty("avatarUrl")]
        public Uri AvatarUrl { get; set; }

        [JsonProperty("additionalParameters")]
        public object AdditionalParameters { get; set; }
    }
}
