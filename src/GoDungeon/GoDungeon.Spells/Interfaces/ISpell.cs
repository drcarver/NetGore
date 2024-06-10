using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Spells.Enum;

namespace GoDungeon.Spells.Interfaces;

public interface ISpell : IStandardTableEntry
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
    /// The magic school of Spell
    /// </summary>
    MagicSchoolEnum MagicSchool { get; set; }

    /// <summary>
    /// The classes that can use the spell
    /// </summary>
    ObservableCollection<ClassEnum>? Casters { get; set; }
}