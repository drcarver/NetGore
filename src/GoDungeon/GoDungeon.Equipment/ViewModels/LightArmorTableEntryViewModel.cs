//
// Light Armor view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Light Armor
/// </summary>
public partial class LightArmorTableEntryViewModel : StandardTableEntryViewModel, ILightArmorTableEntry
{
	/// <summary>
	/// LightArmor
	/// </summary>
	[ObservableProperty]
	private string lightArmor;

	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private string cost;

	/// <summary>
	/// AC
	/// </summary>
	[ObservableProperty]
	private string aC;

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
	private string weight;

}
