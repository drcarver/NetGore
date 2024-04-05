using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// Ranger  A tracker and hunter, the ranger is a 
/// creature of the wild and of tracking down his 
/// favored foes.
/// </summary>
public class Ranger : DataObject, ICharacterClass
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
        },
        new ClassPrerequisite
        {
            Abbreviation = "DEX",
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
    public Ranger()
    {
        Name = nameof(Ranger);
        Description = "Ranger are deft skirmishers, " +
            "either in melee or at range, capable of " +
            "skillfully dancing in and out of " +
            "battle. Their abilities allow " +
            "them to deal significant harm " +
            "to specific types of foes, but " +
            "their skills are valuable against " +
            "all manner of enemies.";
        HitDice = "1d10";
        ClassEnum = ClassEnum.Ranger;
    }
}
