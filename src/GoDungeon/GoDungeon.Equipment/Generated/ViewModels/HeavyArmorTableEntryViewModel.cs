//
// Heavy Armor view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Heavy Armor
/// </summary>
public partial class HeavyArmorTableEntryViewModel : StandardTableEntryViewModel, IHeavyArmorTableEntry
{
	/// <summary>
	/// HeavyArmor
	/// </summary>
	[ObservableProperty]
	private string heavyArmor;

	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private CostViewModel cost;

	/// <summary>
	/// ArmorClassAC
	/// </summary>
	[ObservableProperty]
	private int armorClassAC;

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
