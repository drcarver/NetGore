using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;

using Microsoft.Extensions.Logging;

namespace D20.Core.Abilities;

/// <summary>
/// Dexterity measures agility, reflexes, and balance.
/// </summary>
public class Dexterity : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Dexterity(Creature parent)
        : base(parent)
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
