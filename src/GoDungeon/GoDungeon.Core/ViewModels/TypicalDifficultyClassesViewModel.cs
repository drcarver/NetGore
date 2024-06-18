//
// Typical Difficulty Classes view model
// File=C:\Users\drcarver\Desktop\NetGore\src\UI\GoDungeon.CodeGenerator\docs\rules\abilities\ability_checks.md
//

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels;

/// <summary>
/// Typical Difficulty Classes
/// </summary>
public partial class TypicalDifficultyClassesViewModel : StandardTableEntryViewModel, ITypicalDifficultyClasses
{
    /// <summary>
    /// TaskDifficulty
    /// </summary>
    [ObservableProperty]
    private string taskDifficulty;

    /// <summary>
    /// DC
    /// </summary>
    [ObservableProperty]
    private int dC;

}
