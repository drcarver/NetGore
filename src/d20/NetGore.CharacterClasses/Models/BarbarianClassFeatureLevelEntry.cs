namespace NetGore.CharacterClasses.Models;

public class BarbarianClassFeatureLevelEntry : ClassFeatureLevelEntry
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
