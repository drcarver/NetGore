//
// Armor
//
using System;

using GoDungeon.Core.ViewModels;

using GoDungeon.Equipment.Interfaces;

using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment.ViewModels;

public partial class ArmorViewModel  : BaseObjectViewModel, IArmor
{
	#region Constructor Parameters
	/// <Summary>
	/// Light Armor
	/// <Summary>
	private ILightArmorTable LightArmorTable { get; }

	/// <Summary>
	/// Medium Armor
	/// <Summary>
	private IMediumArmorTable MediumArmorTable { get; }

	/// <Summary>
	/// Heavy Armor
	/// <Summary>
	private IHeavyArmorTable HeavyArmorTable { get; }

	/// <Summary>
	/// Shield
	/// <Summary>
	private IShieldTable ShieldTable { get; }

	/// <Summary>
	/// Getting Into and Out of Armor
	/// <Summary>
	private IGettingIntoandOutofArmorTable GettingIntoandOutofArmorTable { get; }

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
	/// <param name="lightArmorTable">Light Armor</param>
	/// <param name="mediumArmorTable">Medium Armor</param>
	/// <param name="heavyArmorTable">Heavy Armor</param>
	/// <param name="shieldTable">Shield</param>
	/// <param name="gettingIntoandOutofArmorTable">Getting Into and Out of Armor</param>
	/// <param name="loggerFactory">The logger factory</param>
	/// <param name="services">The service provider</param>
	public ArmorViewModel
	(
		ILightArmorTable lightArmorTable,
		IMediumArmorTable mediumArmorTable,
		IHeavyArmorTable heavyArmorTable,
		IShieldTable shieldTable,
		IGettingIntoandOutofArmorTable gettingIntoandOutofArmorTable,
		IServiceProvider services,
		ILoggerFactory loggerFactory
	)
	{
		#region Save off the constructor parameters
		// Light Armor
		LightArmorTable = lightArmorTable;
		LightArmorTable.InitializeTable();

		// Medium Armor
		MediumArmorTable = mediumArmorTable;
		MediumArmorTable.InitializeTable();

		// Heavy Armor
		HeavyArmorTable = heavyArmorTable;
		HeavyArmorTable.InitializeTable();

		// Shield
		ShieldTable = shieldTable;
		ShieldTable.InitializeTable();

		// Getting Into and Out of Armor
		GettingIntoandOutofArmorTable = gettingIntoandOutofArmorTable;
		GettingIntoandOutofArmorTable.InitializeTable();

		// The service provider from the DI
		Services = services;

		// The Logger from the DI factory
		Logger = loggerFactory.CreateLogger(nameof(ArmorViewModel));

		// Initialize the view model
		Initialize();
		#endregion
	}
}
