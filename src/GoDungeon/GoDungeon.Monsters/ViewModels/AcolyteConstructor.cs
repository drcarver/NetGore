//
// AcolyteConstructor
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels;

public partial class AcolyteViewModel  : CreatureViewModel, IAcolyte
{
	#region Constructor Parameters
	/// <Summary>
	/// Acolyte
	/// <Summary>
	private IAcolyteTable AcolyteTable { get; }

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
	/// <param name="acolyteTable">Acolyte</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public AcolyteViewModel
	(
		IAcolyteTable acolyteTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	) : base(services, loggerFactory)
	{
		#region Save off the constructor parameters
		// Acolyte
		AcolyteTable = acolyteTable;
		AcolyteTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(AcolyteViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
