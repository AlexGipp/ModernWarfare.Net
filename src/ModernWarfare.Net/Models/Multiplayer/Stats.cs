using Newtonsoft.Json;

namespace ModernWarfare.Net.Models.Multiplayer
{
    public class Stats
    {
        [JsonProperty("kDRatio")]
        public Information KDRatio { get; set; }

        [JsonProperty("kills")]
        public Information Kills { get; set; }

        [JsonProperty("deaths")]
        public Information Deaths { get; set; }

        [JsonProperty("assists")]
        public Information Assists { get; set; }

        [JsonProperty("suicides")]
        public Information Suicides { get; set; }

        [JsonProperty("totalGamesPlayed")]
        public Information TotalGamesPlayed { get; set; }

        [JsonProperty("wlratio")]
        public Information Wlratio { get; set; }

        [JsonProperty("wins")]
        public Information Wins { get; set; }

        [JsonProperty("losses")]
        public Information Losses { get; set; }

        [JsonProperty("ties")]
        public Information Ties { get; set; }

        [JsonProperty("timePlayedTotal")]
        public Information TimePlayedTotal { get; set; }

        [JsonProperty("averageLife")]
        public Information AverageLife { get; set; }

        [JsonProperty("careerScore")]
        public Information CareerScore { get; set; }

        [JsonProperty("scorePerMinute")]
        public Information ScorePerMinute { get; set; }

        [JsonProperty("scorePerGame")]
        public Information ScorePerGame { get; set; }

        [JsonProperty("accuracy")]
        public Information Information { get; set; }

        [JsonProperty("headshots")]
        public Information Headshots { get; set; }

        [JsonProperty("headshotPercentage")]
        public Information HeadshotPercentage { get; set; }

        [JsonProperty("totalShots")]
        public Information TotalShots { get; set; }

        [JsonProperty("hits")]
        public Information Hits { get; set; }

        [JsonProperty("misses")]
        public Information Misses { get; set; }

        [JsonProperty("rankXP")]
        public Information RankXp { get; set; }

        [JsonProperty("curWinStreak")]
        public Information CurWinStreak { get; set; }

        [JsonProperty("longestKillstreak")]
        public Information LongestKillstreak { get; set; }

        [JsonProperty("level")]
        public Information Level { get; set; }

        [JsonProperty("levelXpTotal")]
        public Information LevelXpTotal { get; set; }

        [JsonProperty("levelProgression")]
        public Information LevelProgression { get; set; }
    }
}