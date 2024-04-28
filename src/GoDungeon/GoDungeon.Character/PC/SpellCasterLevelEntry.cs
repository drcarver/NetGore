using System.Diagnostics.CodeAnalysis;

using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC;

public class SpellCasterLevelEntry : ClassFeatureLevelEntryViewModel
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
