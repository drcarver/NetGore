using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC.Barbarian
{
    public class BarbarianFeatureLevelEntryViewModel : ClassFeatureLevelEntryViewModel, IBarbarianFeatureLevelEntry
    {
        /// <summary>
        /// Number of rages per day
        /// </summary>
        public int Rages { get; set; }

        /// <summary>
        /// Damage per rage
        /// </summary>
        public int RageDamage { get; set; }
    }
}
