using System.Diagnostics.CodeAnalysis;

using D20.Character.Models;

namespace D20.Character.PC.Monk;

public class MonkFeatureLevelEntry : ClassFeatureLevelEntry, IMonkFeatureLevelEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public MonkFeatureLevelEntry()
    {
    }
}
