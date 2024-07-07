namespace GoDungeon.Spells.Interfaces;

public interface ISpellDescription
{
    /// <summary>
    /// the bold description
    /// </summary>
    string? BoldDescription { get; set; }

    /// <summary>
    /// the spell description
    /// </summary>
    string? SpellDescription { get; set; }
}