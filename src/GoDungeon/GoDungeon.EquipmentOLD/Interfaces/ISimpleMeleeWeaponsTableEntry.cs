//
// Simple Melee Weapons view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// ISimple Melee Weapons
/// </summary>
public interface ISimpleMeleeWeaponsTableEntry : IStandardTableEntry
{
	/// <summary>
	/// SimpleMeleeWeapons
	/// </summary>
	public string SimpleMeleeWeapons { get; set; }

	/// <summary>
	/// Cost
	/// </summary>
	public string Cost { get; set; }

	/// <summary>
	/// Damage
	/// </summary>
	public string Damage { get; set; }

	/// <summary>
	/// Weight
	/// </summary>
	public string Weight { get; set; }

	/// <summary>
	/// Properties
	/// </summary>
	public string Properties { get; set; }

}
