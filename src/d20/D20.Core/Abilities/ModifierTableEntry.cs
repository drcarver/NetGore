using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;

namespace D20.Core.Abilities;

public class AbilityModifierTableEntry : BaseObject
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

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityModifierTableEntry()
    {
    }
}