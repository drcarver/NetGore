using System.Diagnostics.CodeAnalysis;

using D20.Character.Models;

namespace D20.Character.PC.Fighter;

public class FighterFeatureLevelEntry : ClassFeatureLevelEntry, IFighterFeatureLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public FighterFeatureLevelEntry()
    {
    }
}
