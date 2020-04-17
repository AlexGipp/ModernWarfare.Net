namespace ModernWarfare.Net.Models.Warzone
{
    public class WarzoneStatsView
    {
        public WarzoneStatsView(LifetimeWarzoneStats lifetimeStats, WarzoneStats brStats, WarzoneStats plunderStats)
        {
            LifetimeStats = lifetimeStats;
            BattleRoyalStats = brStats;
            PlunderStats = plunderStats;
        }

        public LifetimeWarzoneStats LifetimeStats { get; }
        public WarzoneStats BattleRoyalStats { get; }
        public WarzoneStats PlunderStats { get; }
    }
}
