//
// Martial Ranged Weapons view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IMartial Ranged Weapons
/// </summary>
public interface IMartialRangedWeaponsTableEntry : IStandardTableEntry
{
	/// <summary>
	/// MartialRangedWeapons
	/// </summary>
	public string MartialRangedWeapons { get; set; }

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
