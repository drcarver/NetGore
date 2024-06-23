//
// Simple Ranged Weapons view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Simple Ranged Weapons
/// </summary>
public partial class SimpleRangedWeaponsTableEntryViewModel : StandardTableEntryViewModel, ISimpleRangedWeaponsTableEntry
{
	/// <summary>
	/// SimpleRangedWeapons
	/// </summary>
	[ObservableProperty]
	private string simpleRangedWeapons;

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
