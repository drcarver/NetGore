using System.Diagnostics.CodeAnalysis;

namespace GoDungeon.Character.PC.Bard;

public class BardFeatureLevelEntry : SpellCasterLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public BardFeatureLevelEntry()
    {
    }

    /// <summary>
    /// 1st to 9th level spells known
    /// </summary>
    public int SpellsKnown { get; set; }
}
