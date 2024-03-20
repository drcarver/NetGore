using System.Diagnostics.CodeAnalysis;

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
    public Dexterity()
    {
        Name = "Dexterity";
        Description = "Dexterity measures agility, reflexes, and balance.";
        Abbrieviation = "DEX";
    }
}
