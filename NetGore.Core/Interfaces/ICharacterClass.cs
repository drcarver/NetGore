using NetGore.Core.Enum;

namespace NetGore.Core.Interfaces;

public interface ICharacterClass
{
    /// <summary>
    /// The class enum
    /// </summary>
    ClassEnum Class { get; set; }

    /// <summary>
    /// The level in the class (can be different
    /// from the characer level for multiclass 
    /// characters).
    /// </summary>
    int Level { get; set; }

    /// <summary>
    /// The hit dice for the class
    /// </summary>
    string HitDice { get; set; }
}