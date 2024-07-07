//
// Adventuringgear
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.ViewModels;

public partial class AdventuringgearViewModel  : BaseObjectViewModel, IAdventuringgear
{
	#region Constructor Parameters
	/// <Summary>
	/// Ammunition
	/// <Summary>
	private IAmmunitionTable AmmunitionTable { get; }

	/// <Summary>
	/// Arcane focus
	/// <Summary>
	private IArcanefocusTable ArcanefocusTable { get; }

	/// <Summary>
	/// Druidic focus
	/// <Summary>
	private IDruidicfocusTable DruidicfocusTable { get; }

	/// <Summary>
	/// Holy Symbol
	/// <Summary>
	private IHolySymbolTable HolySymbolTable { get; }

	/// <Summary>
	/// Adventuring Gear
	/// <Summary>
	private IAdventuringGearTable AdventuringGearTable { get; }

	/// <Summary>
	/// Container Capacity
	/// <Summary>
	private IContainerCapacityTable ContainerCapacityTable { get; }

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
	/// <param name="ammunitionTable">Ammunition</param>
	/// <param name="arcanefocusTable">Arcane focus</param>
	/// <param name="druidicfocusTable">Druidic focus</param>
	/// <param name="holySymbolTable">Holy Symbol</param>
	/// <param name="adventuringGearTable">Adventuring Gear</param>
	/// <param name="containerCapacityTable">Container Capacity</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public AdventuringgearViewModel
	(
		IAmmunitionTable ammunitionTable,
		IArcanefocusTable arcanefocusTable,
		IDruidicfocusTable druidicfocusTable,
		IHolySymbolTable holySymbolTable,
		IAdventuringGearTable adventuringGearTable,
		IContainerCapacityTable containerCapacityTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	)
	{
		#region Save off the constructor parameters
		// Ammunition
		AmmunitionTable = ammunitionTable;
		AmmunitionTable.InitializeTable();

		// Arcane focus
		ArcanefocusTable = arcanefocusTable;
		ArcanefocusTable.InitializeTable();

		// Druidic focus
		DruidicfocusTable = druidicfocusTable;
		DruidicfocusTable.InitializeTable();

		// Holy Symbol
		HolySymbolTable = holySymbolTable;
		HolySymbolTable.InitializeTable();

		// Adventuring Gear
		AdventuringGearTable = adventuringGearTable;
		AdventuringGearTable.InitializeTable();

		// Container Capacity
		ContainerCapacityTable = containerCapacityTable;
		ContainerCapacityTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(AdventuringgearViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
