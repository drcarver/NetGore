using D20.Character.Models;

namespace D20.Character.PC;

public class BardFeatureLevelEntry : ClassFeatureLevelEntry
{
    /// <summary>
    /// Level 0 spells
    /// </summary>
    public int CantripsKnown { get; set; }

    /// <summary>
    /// 1st to 9th level spells known
    /// </summary>
    public int SpellsKnown { get; set; }

    /// <summary>
    /// Spell slots at this level
    /// </summary>
    public required int[] SpellSlots { get; set; }
}
