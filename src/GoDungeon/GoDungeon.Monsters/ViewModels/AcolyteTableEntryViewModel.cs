//
// Acolyte view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Monsters.Interfaces;

namespace GoDungeon.Monsters.ViewModels;

/// <summary>
/// Acolyte
/// </summary>
public partial class AcolyteTableEntryViewModel : StandardTableEntryViewModel, IAcolyteTableEntry
{
	/// <summary>
	/// STR
	/// </summary>
	[ObservableProperty]
	private string sTR;

	/// <summary>
	/// DEX
	/// </summary>
	[ObservableProperty]
	private string dEX;

	/// <summary>
	/// CON
	/// </summary>
	[ObservableProperty]
	private string cON;

	/// <summary>
	/// INT
	/// </summary>
	[ObservableProperty]
	private string iNT;

	/// <summary>
	/// WIS
	/// </summary>
	[ObservableProperty]
	private string wIS;

	/// <summary>
	/// CHA
	/// </summary>
	[ObservableProperty]
	private string cHA;

}
