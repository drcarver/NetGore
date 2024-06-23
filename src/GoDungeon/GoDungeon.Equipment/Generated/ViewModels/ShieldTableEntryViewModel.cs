//
// Shield view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Shield
/// </summary>
public partial class ShieldTableEntryViewModel : StandardTableEntryViewModel, IShieldTableEntry
{
	/// <summary>
	/// Shield
	/// </summary>
	[ObservableProperty]
	private string shield;

	/// <summary>
	/// Cost
	/// </summary>
	[ObservableProperty]
	private string cost;

	/// <summary>
	/// AC
	/// </summary>
	[ObservableProperty]
	private int aC;

	/// <summary>
	/// Strength
	/// </summary>
	[ObservableProperty]
	private string strength;

	/// <summary>
	/// Stealth
	/// </summary>
	[ObservableProperty]
	private string stealth;

	/// <summary>
	/// Weight
	/// </summary>
	[ObservableProperty]
	private string weight;

}
