using GoDungeon.Character.Interfaces;

namespace GoDungeon.Character.PC.Barbarian;

public interface IBarbarianFeatureLevelEntry : IClassFeatureLevelEntry
{
    /// <summary>
    /// Number of rages per day
    /// </summary>
    int Rages { get; set; }

    /// <summary>
    /// Damage per rage
    /// </summary>
    int RageDamage { get; set; }
}