using System;
using System.Linq;
using System.Threading.Tasks;
using ModernWarfare.Net.Helpers;
using ModernWarfare.Net.Models.Enums;
using ModernWarfare.Net.Models.Multiplayer;
using ModernWarfare.Net.Models.Warzone;

namespace ModernWarfare.Net
{
    public class ModernWarfareClient
    {
        private readonly JsonHelper _jsonHelper;

        public ModernWarfareClient()
        {
            _jsonHelper = new JsonHelper();
        }

        public async Task<MultiplayerStatsView> GetMultiplayerStatsAsync(Platform platform, string username)
        {
            string requestUsername = platform.ToValidUsername(username);
            string requestPlatform = platform.ToApiString();
            var jsonAsStream = await ApiProcessor.GetUser($"https://api.tracker.gg/api/v2/modern-warfare/standard/profile/{requestPlatform}/{requestUsername}");

            var apiData = await _jsonHelper.Deserialise<MultiplayerApiOutput>(jsonAsStream);

            var lifetime = apiData.Data.Segments.First(s => s.Metadata.Name == "Lifetime");
            var accolades = apiData.Data.Segments.First(s => s.Metadata.Name == "Accolades");

            return new MultiplayerStatsView(lifetime.Stats, (AccoladesMultiplayerStats)accolades.Stats);
        }

        public async Task<WarzoneStatsView> GetWarzoneStatsAsync(Platform platform, string username)
        {
            string requestUsername = platform.ToValidUsername(username);
            string requestPlatform = platform.ToApiString();
            var jsonAsStream = await ApiProcessor.GetUser($"https://api.tracker.gg/api/v2/warzone/standard/profile/{requestPlatform}/{requestUsername}");

            var apiData = await _jsonHelper.Deserialise<WarzoneApiOutput>(jsonAsStream);

            var lifetime = apiData.Data.Segments.First(s => s.Metadata.Name == "Lifetime");
            var battleRoyal = apiData.Data.Segments.First(s => s.Metadata.Name == "Battle Royale");
            var plunder = apiData.Data.Segments.First(s => s.Metadata.Name == "Plunder");

            return new WarzoneStatsView(lifetime.Stats, battleRoyal.Stats, plunder.Stats);
        }
    }
}
