using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Spells.Enum;

namespace GoDungeon.Spells.Interfaces
{
    public interface ISpellTableEntry : IStandardTableEntry
    {
        /// <summary>
        /// 1st to 9th level spells
        /// </summary>
        SpellNameEnum SpellType { get; set; }

        /// <summary>
        /// The Spell Level
        /// </summary>
        int Level { get; set; }

        /// <summary>
        /// The magic school
        /// </summary>
        MagicSchoolEnum MagicSchool { get; set; }

        /// <summary>
        /// The classes that can use the spell
        /// </summary>
        ObservableCollection<ClassEnum>? Casters { get; set; }

        /// <summary>
        /// The Casting Time of the Spell
        /// </summary>
        ICastingTime CastingTime { get; set; }

        /// <summary>
        /// The range of the Spell
        /// </summary>
        ISpellRange? SpellRange { get; set; }

        /// <summary>
        /// The components of the Spell
        /// </summary>
        ISpellComponent? SpellComponents { get; set; }

        /// <summary>
        /// The duration of the Spell
        /// </summary>
        string? SpellDuration { get; set; }
    }
}