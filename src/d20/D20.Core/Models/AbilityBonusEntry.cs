using System.Diagnostics.CodeAnalysis;
using D20.Core.Base;
using D20.Core.Interfaces;

namespace D20.Core.Models;

public class AbilityBonusEntry : GameTableEntry, IAbilityBonusEntry
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
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AbilityBonusEntry()
    {
    }
}