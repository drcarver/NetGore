//
// Holy Symbol view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IHoly Symbol
/// </summary>
public interface IHolySymbolTableEntry : IStandardTableEntry
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
