namespace ModernWarfare.Net.Models.Warzone
{
    public class WarzoneStatsView
    {
        public WarzoneStatsView(WarzoneStats lifetimeStats, WarzoneStats brStats, WarzoneStats plunderStats)
        {
            LifetimeStats = lifetimeStats;
            BattleRoyalStats = brStats;
            PlunderStats = plunderStats;
        }

        public WarzoneStats LifetimeStats { get; }
        public WarzoneStats BattleRoyalStats { get; }
        public WarzoneStats PlunderStats { get; }
    }
}
