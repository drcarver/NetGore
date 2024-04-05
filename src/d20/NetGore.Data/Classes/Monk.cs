using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// A student of martial arts, the monk trains his 
/// body to be his greatest weapon and defense.
/// </summary>
public class Monk : DataObject, ICharacterClass
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
    public Monk()
    {
        Name = nameof(Monk);
        Description = "Monks excel at " +
            "overcoming even the most daunting " +
            "perils, striking where it’s least " +
            "expected, and taking advantage of " +
            "enemy vulnerabilities. Fleet of " +
            "foot and skilled in combat, monks " +
            "can navigate any battlefield with " +
            "ease, aiding allies wherever they " +
            "are needed most.";
        HitDice = "1d8";
        ClassEnum = ClassEnum.Monk;
    }
}
