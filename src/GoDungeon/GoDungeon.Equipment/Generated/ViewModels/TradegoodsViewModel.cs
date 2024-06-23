//
// Tradegoods
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.ViewModels;

public partial class TradegoodsViewModel  : BaseObjectViewModel, ITradegoods
{
	#region Constructor Parameters
	/// <Summary>
	/// Trade Goods
	/// <Summary>
	private ITradeGoodsTable TradeGoodsTable { get; }

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
	/// <param name="tradeGoodsTable">Trade Goods</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public TradegoodsViewModel
	(
		ITradeGoodsTable tradeGoodsTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	)
	{
		#region Save off the constructor parameters
		// Trade Goods
		TradeGoodsTable = tradeGoodsTable;
		TradeGoodsTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(TradegoodsViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
