using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// The druid is a worshiper of all things natural – 
/// a spellcaster, a friend to animals, and a skilled 
/// shapechanger.
/// </summary>
public class Druid : DataObject, ICharacterClass
{
    /// <summary>
    /// The ability score prerequisite's for the class.   
    /// </summary>
    public List<ClassPrerequisite> ClassPrerequisites { get; set; } =
    [
        new ClassPrerequisite
        {
            Abbreviation = "WIS",
            Score = 13
        }
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
    [SetsRequiredMembers]
    public Druid()
    {
        Name = nameof(Druid);
        Description = "While some druids might " +
            "keep to the fringe of battle, " +
            "allowing companions and summoned " +
            "creatures to fight while they " +
            "confound foes with the powers of " +
            "nature, others transform into " +
            "deadly beasts and savagely wade " +
            "into combat. Druids worship " +
            "personifications of elemental " +
            "forces, natural powers, or nature " +
            "itself. Typically this means " +
            "devotion to a nature deity, though " +
            "druids are just as likely to revere " +
            "vague spirits, animalistic demigods, " +
            "or even specific awe-inspiring natural " +
            "wonders.";
        HitDice = "1d8";
        ClassEnum = ClassEnum.Druid;
    }
}
