using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ModernWarfare.Net.Helpers;
using ModernWarfare.Net.Models;
using ModernWarfare.Net.Models.Enums;
using ModernWarfare.Net.Models.Multiplayer;
using Newtonsoft.Json;

namespace ModernWarfare.Net
{
    public class ModernWarfareClient
    {
        public async Task<Models.Multiplayer.Stats> GetMultiplayerStatsAsync(Platform platform, string username)
        {
            string requestUsername = platform.ToValidUsername(username);
            string requestPlatform = platform.ToApiString();
            var jsonAsString = await ApiProcessor.GetUser($"https://api.tracker.gg/api/v2/modern-warfare/standard/profile/{requestPlatform}/{requestUsername}");
            var apiData = JsonConvert.DeserializeObject<Models.Multiplayer.ModernWarfareApiOutput>(jsonAsString);
            return apiData.Data.Segments[0].Stats;
        }

        public async Task<Models.Warzone.Stats> GetWarzoneStatsAsync(Platform platform, string username)
        {
            string requestUsername = platform.ToValidUsername(username);
            string requestPlatform = platform.ToApiString();
            var jsonAsString = await ApiProcessor.GetUser($"https://api.tracker.gg/api/v2/warzone/standard/profile/{requestPlatform}/{requestUsername}");
            var apiData = JsonConvert.DeserializeObject<Models.Warzone.ModernWarfareApiOutput>(jsonAsString);
            return apiData.Data.Segments[0].Stats;
        }
    }
}
