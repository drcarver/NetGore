//
// Arcane focus view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Arcane focus
/// </summary>
public partial class ArcanefocusTableEntryViewModel : StandardTableEntryViewModel, IArcanefocusTableEntry
{
	/// <summary>
	/// Item
	/// </summary>
	[ObservableProperty]
	private string item;

	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private string cost;

	/// <summary>
	/// Weight
	/// </summary>
	[ObservableProperty]
	private string weight;

}
