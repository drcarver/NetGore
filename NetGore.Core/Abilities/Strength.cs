using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

namespace NetGore.Core.Abilities;

/// <summary>
/// Strength measures bodily power, athletic training, 
/// and the extent to which you can exert raw physical 
/// force.
/// </summary>
public class Strength : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Strength(ILogger? logger)
        : base(logger)
    {
        Name = "Strength";
        Description = "Strength measures bodily power, athletic training, and the extent to which you can exert raw physical force.";
        Abbreviation = "STR";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Strength(int baseAbility)
        : base(baseAbility)
    {
        Name = "Strength";
        Description = "Strength measures bodily power, athletic training, and the extent to which you can exert raw physical force.";
        Abbreviation = "STR";
    }
}
