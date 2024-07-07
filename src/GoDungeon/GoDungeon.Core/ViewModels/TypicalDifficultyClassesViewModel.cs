//
// Typical Difficulty Classes view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.Abilities.ViewModels;

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
