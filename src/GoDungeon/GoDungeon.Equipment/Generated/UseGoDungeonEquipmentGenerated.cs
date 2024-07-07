//
// C:\Users\drcarver\Desktop\Srd5E\\Equipment\UseGoDungeonEquipmentGenerated.cs
//
using GoDungeon.Equipment.Interfaces;
using GoDungeon.Equipment.Tables;
using GoDungeon.Equipment.ViewModels;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace GoDungeon.Equipment;

public static class DataService
{
	/// <Summary>
	/// DI tables and view models
	/// <Summary>
	public static IServiceCollection UseGoDungeonEquipmentGenerated(this IServiceCollection collection)
	{
		// Add tables to the service collection
		collection
			// Tables
			.AddSingleton<IAdventuringGearTable, AdventuringGearTable>()
			.AddSingleton<IAmmunitionTable, AmmunitionTable>()
			.AddSingleton<IArcanefocusTable, ArcanefocusTable>()
			.AddSingleton<IArtisanstoolsTable, ArtisanstoolsTable>()
			.AddSingleton<IContainerCapacityTable, ContainerCapacityTable>()
			.AddSingleton<IDruidicfocusTable, DruidicfocusTable>()
			.AddSingleton<IGamingsetTable, GamingsetTable>()
			.AddSingleton<IGettingIntoandOutofArmorTable, GettingIntoandOutofArmorTable>()
			.AddSingleton<IHeavyArmorTable, HeavyArmorTable>()
			.AddSingleton<IHolySymbolTable, HolySymbolTable>()
			.AddSingleton<ILightArmorTable, LightArmorTable>()
			.AddSingleton<IMartialMeleeWeaponsTable, MartialMeleeWeaponsTable>()
			.AddSingleton<IMartialRangedWeaponsTable, MartialRangedWeaponsTable>()
			.AddSingleton<IMediumArmorTable, MediumArmorTable>()
			.AddSingleton<IMountsTable, MountsTable>()
			.AddSingleton<IMusicalinstrumentTable, MusicalinstrumentTable>()
			.AddSingleton<IOthertoolsTable, OthertoolsTable>()
			.AddSingleton<ISaddlesTable, SaddlesTable>()
			.AddSingleton<IShieldTable, ShieldTable>()
			.AddSingleton<ISimpleMeleeWeaponsTable, SimpleMeleeWeaponsTable>()
			.AddSingleton<ISimpleRangedWeaponsTable, SimpleRangedWeaponsTable>()
			.AddSingleton<IStandardExchangeRatesTable, StandardExchangeRatesTable>()
			.AddSingleton<ITackHarnessandDrawnVehiclesTable, TackHarnessandDrawnVehiclesTable>()
			.AddSingleton<ITradeGoodsTable, TradeGoodsTable>()
			.AddSingleton<IWaterborneVehiclesTable, WaterborneVehiclesTable>()

			// View Models
			.AddTransient<IAdventuringgear, AdventuringgearViewModel>()
			.AddTransient<IArmor, ArmorViewModel>()
			.AddTransient<ICoins, CoinsViewModel>()
			.AddTransient<IMountsandvehicles, MountsandvehiclesViewModel>()
			.AddTransient<ITools, ToolsViewModel>()
			.AddTransient<ITradegoods, TradegoodsViewModel>()
			.AddTransient<IWeapons, WeaponsViewModel>()
		;

		return collection;
	}
}
