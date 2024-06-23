//
// Mounts view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IMounts
/// </summary>
public interface IMountsTableEntry : IStandardTableEntry
{
	/// <summary>
	/// Item
	/// </summary>
	public string Item { get; set; }

	/// <summary>
	/// Cost
	/// </summary>
	public string Cost { get; set; }

	/// <summary>
	/// Speed
	/// </summary>
	public string Speed { get; set; }

	/// <summary>
	/// CarryingCapacity
	/// </summary>
	public string CarryingCapacity { get; set; }

}
