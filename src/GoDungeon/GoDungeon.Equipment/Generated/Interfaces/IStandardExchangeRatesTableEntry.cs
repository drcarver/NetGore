//
// Standard Exchange Rates view model interface
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces;

/// <summary>
/// IStandard Exchange Rates
/// </summary>
public interface IStandardExchangeRatesTableEntry : IStandardTableEntry
{
	/// <summary>
	/// Coin
	/// </summary>
	public string Coin { get; set; }

	/// <summary>
	/// CP
	/// </summary>
	public int CP { get; set; }

	/// <summary>
	/// SP
	/// </summary>
	public string SP { get; set; }

	/// <summary>
	/// EP
	/// </summary>
	public string EP { get; set; }

	/// <summary>
	/// GP
	/// </summary>
	public string GP { get; set; }

	/// <summary>
	/// PP
	/// </summary>
	public string PP { get; set; }

}
