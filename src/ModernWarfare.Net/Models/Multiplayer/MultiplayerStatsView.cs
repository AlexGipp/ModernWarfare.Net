namespace ModernWarfare.Net.Models.Multiplayer
{
    public class MultiplayerStatsView
    {

        public MultiplayerStatsView(MultiplayerStats lifetimeStats, AccoladesMultiplayerStats accoladesStats)
        {
            AccoladesStats = accoladesStats;
            LifetimeStats = lifetimeStats;
        }

        public MultiplayerStats LifetimeStats { get; set; }
        public AccoladesMultiplayerStats AccoladesStats { get; set; }

    }
}