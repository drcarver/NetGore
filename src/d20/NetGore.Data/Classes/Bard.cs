using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// The bard uses skill and spell alike to bolster 
/// his allies, confound his enemies, and build 
/// upon his fame.
/// </summary>
public class Bard : DataObject, ICharacterClass
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
    public Bard()
    {
        Name = nameof(Bard);
        Description = "Bards capably confuse " +
            "and confound their foes while " +
            "inspiring their allies to " +
            "ever-greater daring. While " +
            "accomplished with both weapons " +
            "and magic, the true strength of " +
            "bards lies outside melee, where " +
            "they can support their companions " +
            "and undermine their foes without " +
            "fear of interruptions to their " +
            "performances.";
        HitDice = "1d8";
        ClassEnum = ClassEnum.Bard;
    }
}
