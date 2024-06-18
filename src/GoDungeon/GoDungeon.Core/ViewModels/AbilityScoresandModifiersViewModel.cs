//
// Ability Scores and Modifiers view model
// File=C:\Users\drcarver\Desktop\NetGore\src\UI\GoDungeon.CodeGenerator\docs\rules\abilities\ability_scores.md
//

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels;

/// <summary>
/// Ability Scores and Modifiers
/// </summary>
public partial class AbilityScoresandModifiersViewModel : StandardTableEntryViewModel, IAbilityScoresandModifiers
{
    /// <summary>
    /// Score
    /// </summary>
    [ObservableProperty]
    private int score;

    /// <summary>
    /// Modifier
    /// </summary>
    [ObservableProperty]
    private int modifier;

}
