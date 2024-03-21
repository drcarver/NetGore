using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Sorcerer : DataObject, ICharacterClass
{
    /// <summary>
    /// The class enum
    /// </summary>
    public ClassEnum Class { get; set; }

    /// <summary>
    /// The level in the class (can be different
    /// from the characer level for multiclass 
    /// characters).
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// The hit dice for the class
    /// </summary>
    public string HitDice { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    [SetsRequiredMembers]
    public Sorcerer(Creature creature)
    {
        Name = nameof(Sorcerer);
        Description = "Sorcerers excel at " +
            "casting a selection of favored " +
            "spells frequently, making them " +
            "powerful battle mages. As they " +
            "become familiar with a specific " +
            "and ever-widening set of spells, " +
            "sorcerers often discover new and " +
            "versatile ways of making use of " +
            "magics other spellcasters might " +
            "overlook. Their bloodlines also " +
            "grant them additional abilities, " +
            "assuring that no two sorcerers " +
            "are ever quite alike";
        HitDice = "1d6";
        Class = ClassEnum.Sorcerer;
        Level = 1;

        creature.Wealth = new Dice("2d6").Total * 10;
    }
}
