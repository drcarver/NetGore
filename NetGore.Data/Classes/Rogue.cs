using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Core.Models;

namespace NetGore.Data.Classes;

public class Rogue : DataObject, ICharacterClass
{
    /// <summary>
    /// The class enum
    /// </summary>
    public ClassEnum Class { get; set; }

    /// <summary>
    /// The level in the class (can be different
    /// from the characer level for multiclass 
    /// characters).
    /// </summary>
    public int Level { get; set; }

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
        Class = ClassEnum.Rogue;
        Level = 1;
    }
}
