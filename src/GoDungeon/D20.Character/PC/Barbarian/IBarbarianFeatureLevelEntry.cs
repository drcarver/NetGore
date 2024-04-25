using D20.Character.Interfaces;

namespace D20.Character.PC.Barbarian;

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