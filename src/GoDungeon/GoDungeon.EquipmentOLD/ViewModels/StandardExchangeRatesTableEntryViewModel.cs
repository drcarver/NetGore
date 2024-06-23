//
// Standard Exchange Rates view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

/// <summary>
/// Standard Exchange Rates
/// </summary>
public partial class StandardExchangeRatesTableEntryViewModel : StandardTableEntryViewModel, IStandardExchangeRatesTableEntry
{
	/// <summary>
	/// Coin
	/// </summary>
	[ObservableProperty]
	private string coin;

	/// <summary>
	/// CP
	/// </summary>
	[ObservableProperty]
	private int cP;

	/// <summary>
	/// SP
	/// </summary>
	[ObservableProperty]
	private string sP;

	/// <summary>
	/// EP
	/// </summary>
	[ObservableProperty]
	private string eP;

	/// <summary>
	/// GP
	/// </summary>
	[ObservableProperty]
	private string gP;

	/// <summary>
	/// PP
	/// </summary>
	[ObservableProperty]
	private string pP;

}
