using D20.Character.Enum;

namespace D20.Character.Interfaces;

public interface IClassInformation
{
    /// <summary>
    /// The class enum
    /// </summary>
    ClassEnum ClassEnum { get; set; }

    /// <summary>
    /// The specifics for a particular class
    /// </summary>
    IClassInformation ClassDetails { get; set; }

    /// <summary>
    /// The level in the class (can be different
    /// from the character level for multiclass 
    /// characters).
    /// </summary>
    int Level { get; set; }

    /// <summary>
    /// Is this the favored class?
    /// </summary>
    bool FavoredClass { get; }
}