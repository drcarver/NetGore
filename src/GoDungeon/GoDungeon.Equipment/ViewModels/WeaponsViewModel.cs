//
// Weapons
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.ViewModels;

public partial class WeaponsViewModel  : BaseObjectViewModel, IWeapons
{
	#region Constructor Parameters
	/// <Summary>
	/// Simple Melee Weapons
	/// <Summary>
	private ISimpleMeleeWeaponsTable SimpleMeleeWeaponsTable { get; }

	/// <Summary>
	/// Simple Ranged Weapons
	/// <Summary>
	private ISimpleRangedWeaponsTable SimpleRangedWeaponsTable { get; }

	/// <Summary>
	/// Martial Melee Weapons
	/// <Summary>
	private IMartialMeleeWeaponsTable MartialMeleeWeaponsTable { get; }

	/// <Summary>
	/// Martial Ranged Weapons
	/// <Summary>
	private IMartialRangedWeaponsTable MartialRangedWeaponsTable { get; }

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
	/// <param name="simpleMeleeWeaponsTable">Simple Melee Weapons</param>
	/// <param name="simpleRangedWeaponsTable">Simple Ranged Weapons</param>
	/// <param name="martialMeleeWeaponsTable">Martial Melee Weapons</param>
	/// <param name="martialRangedWeaponsTable">Martial Ranged Weapons</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public WeaponsViewModel
	(
		ISimpleMeleeWeaponsTable simpleMeleeWeaponsTable,
		ISimpleRangedWeaponsTable simpleRangedWeaponsTable,
		IMartialMeleeWeaponsTable martialMeleeWeaponsTable,
		IMartialRangedWeaponsTable martialRangedWeaponsTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	)
	{
		#region Save off the constructor parameters
		// Simple Melee Weapons
		SimpleMeleeWeaponsTable = simpleMeleeWeaponsTable;
		SimpleMeleeWeaponsTable.InitializeTable();

		// Simple Ranged Weapons
		SimpleRangedWeaponsTable = simpleRangedWeaponsTable;
		SimpleRangedWeaponsTable.InitializeTable();

		// Martial Melee Weapons
		MartialMeleeWeaponsTable = martialMeleeWeaponsTable;
		MartialMeleeWeaponsTable.InitializeTable();

		// Martial Ranged Weapons
		MartialRangedWeaponsTable = martialRangedWeaponsTable;
		MartialRangedWeaponsTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(WeaponsViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
