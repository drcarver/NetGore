//
// Coins
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.ViewModels;

public partial class CoinsViewModel  : BaseObjectViewModel, ICoins
{
	#region Constructor Parameters
	/// <Summary>
	/// Standard Exchange Rates
	/// <Summary>
	private IStandardExchangeRatesTable StandardExchangeRatesTable { get; }

	/// <Summary>
	/// Logger
	/// <Summary>
	ILogger Logger { get; }

	/// <Summary>
	/// The service provider
	/// <Summary>
	IServiceProvider Services { get; }

	/// <Summary>
	/// Initialize the view model
	/// <Summary>
	partial void Initialize();
	#endregion

	/// <Summary>
	/// Constructor
	/// <Summary>
	/// <param name="standardExchangeRatesTable">Standard Exchange Rates</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public CoinsViewModel
	(
		IStandardExchangeRatesTable standardExchangeRatesTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	)
	{
		#region Save off the constructor parameters
		// Standard Exchange Rates
		StandardExchangeRatesTable = standardExchangeRatesTable;
		StandardExchangeRatesTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(CoinsViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
