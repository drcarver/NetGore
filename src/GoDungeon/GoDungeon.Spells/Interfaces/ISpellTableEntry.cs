using System.Collections.ObjectModel;

using GoDungeon.Spells.Enum;

namespace GoDungeon.Spells.Interfaces
{
    public interface ISpellTableEntry
    {
        /// <summary>
        /// 1st to 9th level spells
        /// </summary>
        public SpellEnum SpellEnum { get; set; }

        /// <summary>
        /// The Spell Level
        /// </summary>
        public SpellLevelEnum Level { get; set; }

        /// <summary>
        /// The Type of Spell
        /// </summary>
        public string? SpellType { get; set; }

        /// <summary>
        /// The Casting Time of the Spell
        /// </summary>
        public string? CastingTime { get; set; }

        /// <summary>
        /// The range of the Spell
        /// </summary>
        public string? SpellRange { get; set; }

        /// <summary>
        /// The range of the Spell
        /// </summary>
        public ObservableCollection<string>? SpellComponents { get; set; }

        /// <summary>
        /// The range of the Spell
        /// </summary>
        public string? SpellDuration { get; set; }
    }
}