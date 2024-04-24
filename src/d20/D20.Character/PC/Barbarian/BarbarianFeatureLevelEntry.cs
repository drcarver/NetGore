using System.Diagnostics.CodeAnalysis;

using D20.Character.Models;

namespace D20.Character.PC.Barbarian;

public class BarbarianFeatureLevelEntry : ClassFeatureLevelEntry, IBarbarianFeatureLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public BarbarianFeatureLevelEntry()
    {
    }

    /// <summary>
    /// Number of rages per day
    /// </summary>
    public int Rages { get; set; }

    /// <summary>
    /// Damage per rage
    /// </summary>
    public int RageDamage { get; set; }
}
