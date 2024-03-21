using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Data.Classes;

public class Bard : DataObject, ICharacterClass
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
        Class = ClassEnum.Bard;
        Level = 1;
    }
}
