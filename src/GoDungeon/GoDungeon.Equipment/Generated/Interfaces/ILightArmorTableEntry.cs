//
// Light Armor view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// ILight Armor
/// </summary>
public interface ILightArmorTableEntry : IStandardTableEntry
{
	/// <summary>
	/// LightArmor
	/// </summary>
	public string LightArmor { get; set; }

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
