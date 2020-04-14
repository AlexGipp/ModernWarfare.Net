using System.IO;
using System.Threading.Tasks;
using ModernWarfare.Net.Helpers;
using ModernWarfare.Net.Models.Enums;
using Newtonsoft.Json;

namespace ModernWarfare.Net
{
    public class ModernWarfareClient
    {
        public async Task<Models.Multiplayer.Stats> GetMultiplayerStatsAsync(Platform platform, string username)
        {
            ApiHelper.InitializeClient();
            string requestUsername = platform.ToValidUsername(username);
            string requestPlatform = platform.ToApiString();
            var jsonAsStream = await ApiProcessor.GetUser($"https://api.tracker.gg/api/v2/modern-warfare/standard/profile/{requestPlatform}/{requestUsername}");

            var streamReader = new StreamReader(jsonAsStream);
            var jsonTextReader = new JsonTextReader(streamReader);
            var jsonSerializer = new JsonSerializer();
            var apiData = jsonSerializer.Deserialize<Models.Multiplayer.ModernWarfareApiOutput>(jsonTextReader);

            return apiData.Data.Segments[0].Stats;
        }

        public async Task<Models.Warzone.Stats> GetWarzoneStatsAsync(Platform platform, string username)
        {
            ApiHelper.InitializeClient();
            string requestUsername = platform.ToValidUsername(username);
            string requestPlatform = platform.ToApiString();
            var jsonAsStream = await ApiProcessor.GetUser($"https://api.tracker.gg/api/v2/warzone/standard/profile/{requestPlatform}/{requestUsername}");

            var streamReader = new StreamReader(jsonAsStream);
            var jsonTextReader = new JsonTextReader(streamReader);
            var jsonSerializer = new JsonSerializer();
            var apiData = jsonSerializer.Deserialize<Models.Warzone.ModernWarfareApiOutput>(jsonTextReader);

            return apiData.Data.Segments[0].Stats;
        }
    }
}
