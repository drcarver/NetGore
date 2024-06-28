//
// Simple Melee Weapons view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Simple Melee Weapons
/// </summary>
public partial class SimpleMeleeWeaponsTableEntryViewModel : StandardTableEntryViewModel, ISimpleMeleeWeaponsTableEntry
{
	/// <summary>
	/// SimpleMeleeWeapons
	/// </summary>
	[ObservableProperty]
	private string simpleMeleeWeapons;

	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private CostViewModel cost;

	/// <summary>
	/// Damage
	/// </summary>
	[ObservableProperty]
	private WeaponDamageViewModel damage;

	/// <summary>
	/// Weight
	/// </summary>
	[ObservableProperty]
	private WeightViewModel weight;

	/// <summary>
	/// Properties
	/// </summary>
	[ObservableProperty]
	private string properties;

}
