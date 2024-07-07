//
// Medium Armor view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Medium Armor
/// </summary>
public partial class MediumArmorTableEntryViewModel : StandardTableEntryViewModel, IMediumArmorTableEntry
{
	/// <summary>
	/// MediumArmor
	/// </summary>
	[ObservableProperty]
	private string mediumArmor;

	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private CostViewModel cost;

	/// <summary>
	/// ArmorClassAC
	/// </summary>
	[ObservableProperty]
	private string armorClassAC;

	/// <summary>
	/// Strength
	/// </summary>
	[ObservableProperty]
	private string strength;

	/// <summary>
	/// Stealth
	/// </summary>
	[ObservableProperty]
	private string stealth;

	/// <summary>
	/// Weight
	/// </summary>
	[ObservableProperty]
	private WeightViewModel weight;

}
