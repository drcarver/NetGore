using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Models;

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
    public Constitution(ILogger? logger, Creature parent)
        : base(logger, parent)
    {
        Name = "Constitution";
        Description = "Constitution measures health, stamina, and vital force.";
        Abbreviation = "CON";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Constitution(int baseAbility, Creature parent)
        : base(baseAbility, parent)
    {
        Name = "Constitution";
        Description = "Constitution measures health, stamina, and vital force.";
        Abbreviation = "CON";
    }
}
