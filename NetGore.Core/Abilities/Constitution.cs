using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

namespace NetGore.Core.Abilities;

/// <summary>
/// Constitution measures health, stamina, and vital 
/// force.
/// </summary>
public class Constitution : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Constitution(ILogger? logger)
        : base(logger)
    {
        Name = "Constitution";
        Description = "Constitution measures health, stamina, and vital force.";
        Abbreviation = "CON";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Constitution(int baseAbility)
        : base(baseAbility)
    {
        Name = "Constitution";
        Description = "Constitution measures health, stamina, and vital force.";
        Abbreviation = "CON";
    }
}
