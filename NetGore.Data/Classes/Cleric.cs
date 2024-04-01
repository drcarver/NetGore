using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

/// <summary>
/// A devout follower of a deity, the cleric 
/// can heal wounds, raise the dead, and call 
/// down the wrath of the gods.
/// </summary>
public class Cleric : DataObject, ICharacterClass
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
    public Cleric()
    {
        Name = nameof(Cleric);
        Description = "More than capable of " +
            "upholding the honor of their " +
            "deities in battle, clerics often " +
            "prove stalwart and capable " +
            "combatants. Their true strength " +
            "lies in their capability to draw " +
            "upon the power of their deities, " +
            "whether to increase their own and " +
            "their allies’ prowess in battle, " +
            "to vex their foes with divine " +
            "magic, or to lend healing to " +
            "companions in need. As their " +
            "powers are influenced by their " +
            "faith, all clerics must focus " +
            "their worship upon a divine source. " +
            "While the vast majority of clerics " +
            "revere a specific deity, a small " +
            "number dedicate themselves to a " +
            "divine concept worthy of devotion—such " +
            "as battle, death, justice, or " +
            "knowledge—free of a deific abstraction. ";
        HitDice = "1d8";
        ClassEnum = ClassEnum.Cleric;
    }
}
