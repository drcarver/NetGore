//
// ToolsConstructor
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.ViewModels;

public partial class ToolsViewModel  : CreatureViewModel, ITools
{
	#region Constructor Parameters
	/// <Summary>
	/// Artisan's tools
	/// <Summary>
	private IArtisanstoolsTable ArtisanstoolsTable { get; }

	/// <Summary>
	/// Gaming set
	/// <Summary>
	private IGamingsetTable GamingsetTable { get; }

	/// <Summary>
	/// Musical instrument
	/// <Summary>
	private IMusicalinstrumentTable MusicalinstrumentTable { get; }

	/// <Summary>
	/// Other tools
	/// <Summary>
	private IOthertoolsTable OthertoolsTable { get; }

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
	/// <param name="artisanstoolsTable">Artisan's tools</param>
	/// <param name="gamingsetTable">Gaming set</param>
	/// <param name="musicalinstrumentTable">Musical instrument</param>
	/// <param name="othertoolsTable">Other tools</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public ToolsViewModel
	(
		IArtisanstoolsTable artisanstoolsTable,
		IGamingsetTable gamingsetTable,
		IMusicalinstrumentTable musicalinstrumentTable,
		IOthertoolsTable othertoolsTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	) : base(services, loggerFactory)
	{
		#region Save off the constructor parameters
		// Artisan's tools
		ArtisanstoolsTable = artisanstoolsTable;
		ArtisanstoolsTable.InitializeTable();

		// Gaming set
		GamingsetTable = gamingsetTable;
		GamingsetTable.InitializeTable();

		// Musical instrument
		MusicalinstrumentTable = musicalinstrumentTable;
		MusicalinstrumentTable.InitializeTable();

		// Other tools
		OthertoolsTable = othertoolsTable;
		OthertoolsTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(ToolsViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
