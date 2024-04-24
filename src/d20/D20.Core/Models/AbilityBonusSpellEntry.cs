using System.Diagnostics.CodeAnalysis;
using D20.Core.Base;
using D20.Core.Interfaces;

namespace D20.Core.Models;

public class AbilityBonusSpellEntry : AbilityBonusEntry, IAbilityBonusSpellEntry
{
    /// <summary>
    /// The bonus spells
    /// </summary>
    public int[]? BonusSpells { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityBonusSpellEntry()
    {
    }
}