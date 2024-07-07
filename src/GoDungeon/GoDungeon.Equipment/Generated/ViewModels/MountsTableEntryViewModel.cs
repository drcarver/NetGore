//
// Mounts view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Mounts
/// </summary>
public partial class MountsTableEntryViewModel : StandardTableEntryViewModel, IMountsTableEntry
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
	private CostViewModel cost;

	/// <summary>
	/// Speed
	/// </summary>
	[ObservableProperty]
	private string speed;

	/// <summary>
	/// CarryingCapacity
	/// </summary>
	[ObservableProperty]
	private string carryingCapacity;

}
