using D20.Core.Interfaces;

namespace D20.Core.Models
{
    public class AbilityBonusSpellEntry : AbilityBonusEntry, IAbilityBonusSpellEntry
    {
        /// <summary>
        /// The bonus spells
        /// </summary>
        public int[]? BonusSpells { get; set; }
    }
}