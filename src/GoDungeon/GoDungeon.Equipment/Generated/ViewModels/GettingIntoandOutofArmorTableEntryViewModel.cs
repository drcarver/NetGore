//
// Getting Into and Out of Armor view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Getting Into and Out of Armor
/// </summary>
public partial class GettingIntoandOutofArmorTableEntryViewModel : StandardTableEntryViewModel, IGettingIntoandOutofArmorTableEntry
{
	/// <summary>
	/// Category
	/// </summary>
	[ObservableProperty]
	private string category;

	/// <summary>
	/// Don
	/// </summary>
	[ObservableProperty]
	private string don;

	/// <summary>
	/// Doff
	/// </summary>
	[ObservableProperty]
	private string doff;

}
