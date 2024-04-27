using System.Diagnostics.CodeAnalysis;
using D20.Core.Models;
using D20.Spells.Enum;

namespace D20.Spells.Tables;

public class SpellTableEntry : StandardTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public SpellTableEntry()
    {
    }

    /// <summary>
    /// 1st to 9th level spells
    /// </summary>
    public SpellEnum SpellEnum { get; set; }

    /// <summary>
    /// The Spell Level
    /// </summary>
    public SpellLevelEnum Level { get; set; }

    /// <summary>
    /// The Type of Spell
    /// </summary>
    public string? SpellType { get; set; }

    /// <summary>
    /// The Casting Time of the Spell
    /// </summary>
    public string? CastingTime { get; set; }

    /// <summary>
    /// The range of the Spell
    /// </summary>
    public string? SpellRange { get; set; }

    /// <summary>
    /// The range of the Spell
    /// </summary>
    public string[]? SpellComponents { get; set; }

    /// <summary>
    /// The range of the Spell
    /// </summary>
    public string? SpellDuration { get; set; }
}
