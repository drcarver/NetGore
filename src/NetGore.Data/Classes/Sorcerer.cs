using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// Sorcerer The spellcasting sorcerer is born with 
/// an innate knack for magic and has strange, 
/// eldritch powers.
/// </summary>
public class Sorcerer : DataObject, ICharacterClass
{
    /// <summary>
    /// The ability score prerequisite's for the class.   
    /// </summary>
    public List<ClassPrerequisite> ClassPrerequisites { get; set; } =
    [
        new ClassPrerequisite
        {
            Abbreviation = "CHA",
            Score = 13
        },
    ];

    /// <summary>
    /// The class enum
    /// </summary>
    public ClassEnum ClassEnum { get; set; }

    /// <summary>
    /// The hit dice for the class
    /// </summary>
    public string HitDice { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="creature"></param>
    [SetsRequiredMembers]
    public Sorcerer()
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
        ClassEnum = ClassEnum.Sorcerer;
    }
}
