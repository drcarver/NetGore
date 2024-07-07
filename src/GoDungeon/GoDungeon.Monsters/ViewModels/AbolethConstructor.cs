//
// AbolethConstructor
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Monsters.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Monsters.ViewModels;

public partial class AbolethViewModel  : CreatureViewModel, IAboleth
{
	#region Constructor Parameters
	/// <Summary>
	/// Aboleth
	/// <Summary>
	private IAbolethTable AbolethTable { get; }

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
	/// <param name="abolethTable">Aboleth</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public AbolethViewModel
	(
		IAbolethTable abolethTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	) : base(services, loggerFactory)
	{
		#region Save off the constructor parameters
		// Aboleth
		AbolethTable = abolethTable;
		AbolethTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(AbolethViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
