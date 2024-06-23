//
// Getting Into and Out of Armor view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IGetting Into and Out of Armor
/// </summary>
public interface IGettingIntoandOutofArmorTableEntry : IStandardTableEntry
{
	/// <summary>
	/// Category
	/// </summary>
	public string Category { get; set; }

	/// <summary>
	/// Don
	/// </summary>
	public string Don { get; set; }

	/// <summary>
	/// Doff
	/// </summary>
	public string Doff { get; set; }

}
