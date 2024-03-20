using System.Diagnostics.CodeAnalysis;

using Microsoft.Extensions.Logging;

namespace NetGore.Core.Ablities;

/// <summary>
/// Dexterity measures agility, reflexes, and balance.
/// </summary>
public class Dexterity : AbilityBase
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public Dexterity(ILogger logger)
        : base(logger)
    {
        Name = "Dexterity";
        Description = "Dexterity measures agility, reflexes, and balance.";
        Abbrieviation = "DEX";
    }
}
