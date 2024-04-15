using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;

namespace D20.Core.Abilities;

public class AbilityBonusSpellEntry : AbilityBonusEntry 
{
    /// <summary>
    /// The bonus spells
    /// </summary>
    public int[]? BonusSpells { get; set; } = new int[9];

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityBonusSpellEntry()
    {
    }
}