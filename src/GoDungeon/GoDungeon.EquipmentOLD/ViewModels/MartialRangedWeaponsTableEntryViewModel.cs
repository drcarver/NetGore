//
// Martial Ranged Weapons view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Martial Ranged Weapons
/// </summary>
public partial class MartialRangedWeaponsTableEntryViewModel : StandardTableEntryViewModel, IMartialRangedWeaponsTableEntry
{
	/// <summary>
	/// MartialRangedWeapons
	/// </summary>
	[ObservableProperty]
	private string martialRangedWeapons;

	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private string cost;

	/// <summary>
	/// Damage
	/// </summary>
	[ObservableProperty]
	private string damage;

	/// <summary>
	/// Weight
	/// </summary>
	[ObservableProperty]
	private string weight;

	/// <summary>
	/// Properties
	/// </summary>
	[ObservableProperty]
	private string properties;

}
