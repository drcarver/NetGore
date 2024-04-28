using System.Diagnostics.CodeAnalysis;

using GoDungeon.Character.ViewModels;

namespace GoDungeon.Character.PC.Monk;

public class MonkFeatureLevelEntry : ClassFeatureLevelEntryViewModel, IMonkFeatureLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public MonkFeatureLevelEntry()
    {
    }
}
