using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// Fighter Brave and stalwart, the fighter is a 
/// master of all manner of arms and armor.
/// </summary>
public class Fighter : DataObject, ICharacterClass
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
    /// Level up the class
    /// </summary>
    public void LevelUp()
    {

    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Fighter()
    {
        Name = nameof(ClassEnum.Fighter);
        Description = "Fighters excel at " +
              "combat—defeating their enemies, " +
              "controlling the flow of battle, " +
              "and surviving such sorties " +
              "themselves. While their specific " +
              "weapons and methods grant them a " +
              "wide variety of tactics, few can " +
              "match fighters for sheer battle " +
              "prowess.";
        HitDice = "1d10";
        ClassEnum = ClassEnum.Fighter;
    }
}
