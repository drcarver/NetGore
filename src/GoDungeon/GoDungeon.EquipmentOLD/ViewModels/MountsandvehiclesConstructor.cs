//
// MountsandvehiclesConstructor
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.ViewModels;

public partial class MountsandvehiclesViewModel  : IMountsandvehicles
{
	#region Constructor Parameters
	/// <Summary>
	/// Mounts
	/// <Summary>
	private IMountsTable MountsTable { get; }

	/// <Summary>
	/// Tack, Harness, and Drawn Vehicles
	/// <Summary>
	private ITackHarnessandDrawnVehiclesTable TackHarnessandDrawnVehiclesTable { get; }

	/// <Summary>
	/// Saddles
	/// <Summary>
	private ISaddlesTable SaddlesTable { get; }

	/// <Summary>
	/// Waterborne Vehicles
	/// <Summary>
	private IWaterborneVehiclesTable WaterborneVehiclesTable { get; }

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
	/// <param name="mountsTable">Mounts</param>
	/// <param name="tackHarnessandDrawnVehiclesTable">Tack, Harness, and Drawn Vehicles</param>
	/// <param name="saddlesTable">Saddles</param>
	/// <param name="waterborneVehiclesTable">Waterborne Vehicles</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public MountsandvehiclesViewModel
	(
		IMountsTable mountsTable,
		ITackHarnessandDrawnVehiclesTable tackHarnessandDrawnVehiclesTable,
		ISaddlesTable saddlesTable,
		IWaterborneVehiclesTable waterborneVehiclesTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	)
	{
		#region Save off the constructor parameters
		// Mounts
		MountsTable = mountsTable;
		MountsTable.InitializeTable();

		// Tack, Harness, and Drawn Vehicles
		TackHarnessandDrawnVehiclesTable = tackHarnessandDrawnVehiclesTable;
		TackHarnessandDrawnVehiclesTable.InitializeTable();

		// Saddles
		SaddlesTable = saddlesTable;
		SaddlesTable.InitializeTable();

		// Waterborne Vehicles
		WaterborneVehiclesTable = waterborneVehiclesTable;
		WaterborneVehiclesTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(MountsandvehiclesViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
