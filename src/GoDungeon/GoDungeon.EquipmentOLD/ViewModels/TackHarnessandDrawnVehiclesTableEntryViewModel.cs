//
// Tack, Harness, and Drawn Vehicles view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Tack, Harness, and Drawn Vehicles
/// </summary>
public partial class TackHarnessandDrawnVehiclesTableEntryViewModel : StandardTableEntryViewModel, ITackHarnessandDrawnVehiclesTableEntry
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
