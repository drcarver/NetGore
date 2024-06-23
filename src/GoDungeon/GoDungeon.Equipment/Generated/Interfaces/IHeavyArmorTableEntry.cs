//
// Heavy Armor view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IHeavy Armor
/// </summary>
public interface IHeavyArmorTableEntry : IStandardTableEntry
{
	/// <summary>
	/// HeavyArmor
	/// </summary>
	public string HeavyArmor { get; set; }

	/// <summary>
	/// Cost
	/// </summary>
	public string Cost { get; set; }

	/// <summary>
	/// AC
	/// </summary>
	public int AC { get; set; }

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
