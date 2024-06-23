//
// Saddles view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// ISaddles
/// </summary>
public interface ISaddlesTableEntry : IStandardTableEntry
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
