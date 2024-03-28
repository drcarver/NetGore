using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

namespace NetGore.Core.Abilities;

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
    public Charisma(ILogger? logger)
        : base(logger)
    {
        Name = "Charisma";
        Description = "Charisma measures your ability to interact effectively with others. It includes such factors as confidence and eloquence, and it can represent a charming or commanding personality.";
        Abbreviation = "CHA";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Charisma(int baseAbility)
        : base(baseAbility)
    {
        Name = "Charisma";
        Description = "Charisma measures your ability to interact effectively with others. It includes such factors as confidence and eloquence, and it can represent a charming or commanding personality.";
        Abbreviation = "CHA";
    }
}
