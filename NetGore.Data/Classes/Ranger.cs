using System.Diagnostics.CodeAnalysis;

using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Data.Classes;

public class Ranger : DataObject, ICharacterClass
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
        Class = ClassEnum.Ranger;
        Level = 1;
    }
}
