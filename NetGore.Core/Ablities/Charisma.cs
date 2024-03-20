using System.Diagnostics.CodeAnalysis;

namespace NetGore.Core.Ablities;

/// <summary>
/// Charisma measures your ability to interact effectively 
/// with others. It includes such factors as confidence 
/// and eloquence, and it can represent a charming or 
/// commanding personality.
/// </summary>
public class Charisma : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Charisma()
    {
        Name = "Charisma";
        Description = "Charisma measures your ability to interact effectively with others. It includes such factors as confidence and eloquence, and it can represent a charming or commanding personality.";
        Abbrieviation = "CHA";
    }
}
