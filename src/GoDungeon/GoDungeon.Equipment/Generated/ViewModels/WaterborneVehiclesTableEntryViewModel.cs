//
// Waterborne Vehicles view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Waterborne Vehicles
/// </summary>
public partial class WaterborneVehiclesTableEntryViewModel : StandardTableEntryViewModel, IWaterborneVehiclesTableEntry
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
	/// Speed
	/// </summary>
	[ObservableProperty]
	private string speed;

}
