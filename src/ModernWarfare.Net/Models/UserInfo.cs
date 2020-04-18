using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace ModernWarfare.Net.Models
{
    public class UserInfo
    {
        [JsonProperty("isPremium")]
        public bool IsPremium { get; set; }

        [JsonProperty("isVerified")]
        public bool IsVerified { get; set; }

        [JsonProperty("isInfluencer")]
        public bool IsInfluencer { get; set; }

        [JsonProperty("countryCode")]
        public string CountryCode { get; set; }

        [JsonProperty("customAvatarUrl")]
        public object CustomAvatarUrl { get; set; }

        [JsonProperty("socialAccounts")]
        public object[] SocialAccounts { get; set; }
    }
}
