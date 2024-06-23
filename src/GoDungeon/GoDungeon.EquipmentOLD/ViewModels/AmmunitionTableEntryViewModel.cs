//
// Ammunition view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Ammunition
/// </summary>
public partial class AmmunitionTableEntryViewModel : StandardTableEntryViewModel, IAmmunitionTableEntry
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
