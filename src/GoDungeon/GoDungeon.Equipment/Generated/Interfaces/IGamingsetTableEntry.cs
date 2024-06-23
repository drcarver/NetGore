//
// Gaming set view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IGaming set
/// </summary>
public interface IGamingsetTableEntry : IStandardTableEntry
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
