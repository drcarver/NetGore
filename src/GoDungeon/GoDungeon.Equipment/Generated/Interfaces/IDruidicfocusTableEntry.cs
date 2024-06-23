//
// Druidic focus view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IDruidic focus
/// </summary>
public interface IDruidicfocusTableEntry : IStandardTableEntry
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
	/// Weight
	/// </summary>
	public string Weight { get; set; }

}
