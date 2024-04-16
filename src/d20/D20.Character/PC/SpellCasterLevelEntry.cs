using System.Diagnostics.CodeAnalysis;

using D20.Character.Models;

namespace D20.Character.PC;

public class SpellCasterLevelEntry : ClassFeatureLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public SpellCasterLevelEntry()
    {
    }

    /// <summary>
    /// Level 0 spells
    /// </summary>
    public int CantripsKnown { get; set; }

    /// <summary>
    /// Spell slots at this level
    /// </summary>
    public int[]? SpellSlots { get; set; }
}
