using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Warzone
{
    public class Stats
    {
        [JsonProperty("kills")]
        public Information Kills { get; set; }

        [JsonProperty("deaths")]
        public Information Deaths { get; set; }

        [JsonProperty("downs")]
        public Information Downs { get; set; }

        [JsonProperty("revives")]
        public Information Revives { get; set; }

        [JsonProperty("kdRatio")]
        public Information KdRatio { get; set; }

        [JsonProperty("wins")]
        public Information Wins { get; set; }

        [JsonProperty("top5")]
        public Information Top5 { get; set; }

        [JsonProperty("top10")]
        public Information Top10 { get; set; }

        [JsonProperty("top25")]
        public Information Top25 { get; set; }

        [JsonProperty("gamesPlayed")]
        public Information GamesPlayed { get; set; }

        [JsonProperty("timePlayed")]
        public Information TimePlayed { get; set; }

        [JsonProperty("wlRatio")]
        public Information WlRatio { get; set; }

        [JsonProperty("score")]
        public Information Score { get; set; }

        [JsonProperty("scorePerMinute")]
        public Information ScorePerMinute { get; set; }

        [JsonProperty("scorePerGame")]
        public Information ScorePerGame { get; set; }

        [JsonProperty("cash")]
        public Information Cash { get; set; }

        [JsonProperty("contracts")]
        public Information Contracts { get; set; }

        [JsonProperty("averageLife")]
        public Information Information { get; set; }
    }
}