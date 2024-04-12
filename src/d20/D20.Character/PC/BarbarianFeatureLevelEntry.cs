using D20.Character.Models;

namespace D20.Character.PC;

public class BarbarianFeatureLevelEntry : ClassFeatureLevelEntry
{
    /// <summary>
    /// Number of rages per day
    /// </summary>
    public int Rages { get; set; }

    /// <summary>
    /// Damage per rage
    /// </summary>
    public int RageDamage { get; set; }
}
