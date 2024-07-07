//
// Typical Difficulty Classes view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

namespace GoDungeon.Core.Interfaces;

/// <summary>
/// ITypical Difficulty Classes
/// </summary>
public interface ITypicalDifficultyClasses : IStandardTableEntry
{
    /// <summary>
    /// TaskDifficulty
    /// </summary>
    public string TaskDifficulty { get; set; }

    /// <summary>
    /// DC
    /// </summary>
    public int DC { get; set; }

}
