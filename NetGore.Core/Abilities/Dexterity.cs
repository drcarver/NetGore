using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

using NetGore.Core.Models;

namespace NetGore.Core.Abilities;

/// <summary>
/// Dexterity measures agility, reflexes, and balance.
/// </summary>
public class Dexterity : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Dexterity(ILogger? logger, Creature parent)
        : base(logger, parent)
    {
        Name = "Dexterity";
        Description = "Dexterity measures agility, reflexes, and balance.";
        Abbreviation = "DEX";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Dexterity(int baseAbility, Creature parent)
        : base(baseAbility, parent)
    {
        Name = "Dexterity";
        Description = "Dexterity measures agility, reflexes, and balance.";
        Abbreviation = "DEX";
    }
}
