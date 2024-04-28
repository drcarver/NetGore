using System.Diagnostics.CodeAnalysis;

using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC.Fighter;

public class FighterFeatureLevelEntry : ClassFeatureLevelEntryViewModel, IFighterFeatureLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public FighterFeatureLevelEntry()
    {
    }
}
