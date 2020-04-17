namespace ModernWarfare.Net.Models.Warzone
{
    public class LifetimeWarzoneStats : WarzoneStats
    {
        public LevelStats Level { get; set; }
        public LevelStats LevelXpTotal { get; set; }
        public LevelStats LevelProgression { get; set; }
    }
}
