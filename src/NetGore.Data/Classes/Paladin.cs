using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// Paladin The paladin is the knight in shining 
/// armor, a devoted follower of law and good.
/// </summary>
public class Paladin : DataObject, ICharacterClass
{
    /// <summary>
    /// The ability score prerequisite's for the class.   
    /// </summary>
    public List<ClassPrerequisite> ClassPrerequisites { get; set; } =
    [
        new ClassPrerequisite
        {
            Abbreviation = "STR",
            Score = 13
        },
        new ClassPrerequisite
        {
            Abbreviation = "CHA",
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
    public Paladin()
    {
        Name = nameof(Paladin);
        Description = " Paladins serve as " +
            "beacons for their allies within " +
            "the chaos of battle. While " +
            "deadly opponents of evil, they " +
            "can also empower goodly souls " +
            "to aid in their crusades. Their " +
            "magic and martial skills also " +
            "make them well suited to defending " +
            "others and blessing the fallen " +
            "with the strength to continue " +
            "fighting.";
        HitDice = "1d10";
        ClassEnum = ClassEnum.Paladin;
    }
}
