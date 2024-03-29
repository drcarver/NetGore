using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

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
    public Dexterity(ILogger? logger)
        : base(logger)
    {
        Name = "Dexterity";
        Description = "Dexterity measures agility, reflexes, and balance.";
        Abbreviation = "DEX";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Dexterity(int baseAbility)
        : base(baseAbility)
    {
        Name = "Dexterity";
        Description = "Dexterity measures agility, reflexes, and balance.";
        Abbreviation = "DEX";
    }
}
