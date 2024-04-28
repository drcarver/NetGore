using System.Diagnostics.CodeAnalysis;

using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC.Barbarian;

public class BarbarianFeatureLevelEntry : ClassFeatureLevelEntryViewModel, IBarbarianFeatureLevelEntry
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
