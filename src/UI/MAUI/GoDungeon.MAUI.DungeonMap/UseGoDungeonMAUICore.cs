using System.Reflection;

using CommunityToolkit.Maui;

using GoDungeon.Core.Tables;
using GoDungeon.MAUI.DungeonMap.Interfaces;
using GoDungeon.MAUI.DungeonMap.Tables;
using GoDungeon.MAUI.DungeonMap.ViewModels;
using GoDungeon.MAUI.DungeonMap.Views;

namespace GoDungeon.MAUI.DungeonMap;

public static class DataServices
{
    /// <summary>
    /// Get all the IGameable entries
    /// </summary>
    /// <returns></returns>
    public static List<Type> MAUIDungeonMapTables => Assembly
        .GetExecutingAssembly()
        .GetExportedTypes()
        .Where(t =>
                t.IsSubclassOf(typeof(GameTable))
            && t.Name != nameof(RandomTable)
            && t.Name != nameof(NamedTable))
        .ToList();

    /// <summary>
    /// The GoDungeon Core tables and services
    /// </summary>
    /// <param name="collection">The DI service collection</param>
    /// <returns>The services collection</returns>
    public static IServiceCollection UseGoDungeonMAUIDungeonMap(this IServiceCollection collection)
    {
        //collection
        // Add all the game table types as transient
        collection
            .AddTransient<IDungeonMapViewModel, DungeonMapViewModel>()

             // The tables
            .AddSingleton<IBeyondADoorTable, BeyondADoorTable>()
            .AddSingleton<IChamberExitTable, ChamberExitTable>()
            .AddSingleton<IChamberTable, ChamberTable>()
            .AddSingleton<IDoorTypeTable, DoorTypeTable>()
            .AddSingleton<IDungeonHistoryTable, DungeonHistoryTable>()
            .AddSingleton<IDungeonPurposeTable, DungeonPurposeTable>()
            .AddSingleton<IExitLocationTable, ExitLocationTable>()
            .AddSingleton<IExitTypeTable, ExitTypeTable>()
            .AddSingleton<IFormOfGovernmentTable, FormOfGovernmentTable>()
            .AddSingleton<ILeaderTypeTable, LeaderTypeTable>()
            .AddSingleton<IMonumentsTable, MonumentsTable>()
            .AddSingleton<IPassageTable, PassageTable>()
            .AddSingleton<IPassageWidthTable, PassageWidthTable>()
            .AddSingleton<IPrecipitationTable, PrecipitationTable>()
            .AddSingleton<IRaceRelationsTable, RaceRelationsTable>()
            .AddSingleton<ISettlementsTable, SettlementTable>()
            .AddSingleton<IStairsTable, StairsTable>()
            .AddSingleton<IStartingAreaTable, StartingAreaTable>()
            .AddSingleton<ITemperatureTable, TemperatureTable>()
            .AddSingleton<IWeirdLocalesTable, WeirdLocalesTable>()
            .AddSingleton<IWindTable, WindTable>()
            .AddSingleton<IWorldShakingEventsTable, WorldShakingEventsTable>()

            // Add the views
            .AddTransientWithShellRoute<DungeonMapPage, DungeonMapViewModel>(nameof(DungeonMapPage))
            ;

        return collection;
    }
}
