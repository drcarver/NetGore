//
// Adventuring Gear view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Adventuring Gear
/// </summary>
public partial class EquipmentTableEntryViewModel : StandardTableEntryViewModel, IEquipmentTableEntry
{
	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private CostViewModel? cost;

	/// <summary>
	/// Weight
	/// </summary>
	[ObservableProperty]
	private WeightViewModel? weight;

}
