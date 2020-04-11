using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ModernWarfare.Net.Helpers;
using ModernWarfare.Net.Models;
using ModernWarfare.Net.Models.Enums;
using Newtonsoft.Json;

namespace ModernWarfare.Net
{
    public class ModernWarfareClient
    {
        public async Task<MultiplayerStats> GetMultiplayerStatsAsync(Platform platform, string username)
        {
            string requestPlatform = PlatformExtensions.ToApiString(platform);
            var jsonAsString = await ApiProcessor.GetUser($"https://api.tracker.gg/api/v2/modern-warfare/standard/profile/{requestPlatform}/{username}");
            return JsonConvert.DeserializeObject<MultiplayerStats>(jsonAsString);
        }

        public async Task<WarzoneStats> GetWarzoneStatsAsync(Platform platform, string username)
        {
            string requestPlatform = PlatformExtensions.ToApiString(platform);
            var jsonAsString = await ApiProcessor.GetUser($"https://api.tracker.gg/api/v2/warzone/standard/profile/{requestPlatform}/{username}");
            return JsonConvert.DeserializeObject<WarzoneStats>(jsonAsString);
        }
    }
}
