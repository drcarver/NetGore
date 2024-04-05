using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// The barbarian is a brutal berserker from beyond 
/// the edge of civilized lands.
/// </summary>
public class Barbarian : DataObject, ICharacterClass
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
    public Barbarian()
    {
        Name = nameof(Barbarian);
        Description = "Barbarians excel in " +
            "combat, possessing the martial " +
            "prowess and fortitude to take " +
            "on foes seemingly far superior " +
            "to themselves. With rage granting " +
            "them boldness and daring beyond " +
            "that of most other warriors, " +
            "barbarians charge furiously into " +
            "battle and ruin all who would " +
            "stand in their way.";
        HitDice = "1d12";
        ClassEnum = ClassEnum.Barbarian;
    }
}
