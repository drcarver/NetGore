using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// Rogue The rogue is a thief and a scout, an 
/// opportunist capable of delivering brutal 
/// strikes against unwary foes.
/// </summary>
public class Rogue : DataObject, ICharacterClass
{
    /// <summary>
    /// The ability score prerequisite's for the class.   
    /// </summary>
    public List<ClassPrerequisite> ClassPrerequisites { get; set; } =
    [
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
    public Rogue()
    {
        Name = nameof(Rogue);
        Description = "Rogues excel at moving " +
            "about unseen and catching foes " +
            "unaware, and tend to avoid " +
            "head-to-head combat. Their " +
            "varied skills and abilities " +
            "allow them to be highly versatile, " +
            "with great variations in expertise " +
            "existing between different rogues. " +
            "Most, however, excel in overcoming " +
            "hindrances of all types, from " +
            "unlocking doors and disarming traps " +
            "to outwitting magical hazards and " +
            "conning dull-witted opponents.";
        HitDice = "1d8";
        ClassEnum = ClassEnum.Rogue;
    }
}
