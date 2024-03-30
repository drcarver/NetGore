namespace NetGore.Core.Abilities;

public class ModifierTableEntry
{
    /// <summary>
    /// The range of a ability scores for this entry
    /// </summary>
    public Range Score { get; set; }

    /// <summary>
    /// The ability modifier
    /// </summary>
    public int Modifier { get; set; }

    /// <summary>
    /// The bonus spells
    /// </summary>
    public int[]? BonusSpells { get; set; } = new int[9];

    /// <summary>
    /// Can we even cas a spell?
    /// </summary>
    public bool CanCastspells => BonusSpells != null;
}