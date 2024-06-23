//
// Medium Armor view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IMedium Armor
/// </summary>
public interface IMediumArmorTableEntry : IStandardTableEntry
{
	/// <summary>
	/// MediumArmor
	/// </summary>
	public string MediumArmor { get; set; }

	/// <summary>
	/// Cost
	/// </summary>
	public string Cost { get; set; }

	/// <summary>
	/// AC
	/// </summary>
	public string AC { get; set; }

	/// <summary>
	/// Strength
	/// </summary>
	public string Strength { get; set; }

	/// <summary>
	/// Stealth
	/// </summary>
	public string Stealth { get; set; }

	/// <summary>
	/// Weight
	/// </summary>
	public string Weight { get; set; }

}
