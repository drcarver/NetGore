using System.Reflection;

using GoDungeon.Core.Tables;
using GoDungeon.MAUI.DungeonMap.Interfaces;
using GoDungeon.MAUI.DungeonMap.Tables;
using GoDungeon.MAUI.DungeonMap.ViewModels;
using GoDungeon.RandomDungeon.Tables;

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
        collection.AddTransient<IDungeonMapViewModel, DungeonMapViewModel>();

        // The tables
        collection.AddTransient<IBeyondADoorTable, BeyondADoorTable>();
        collection.AddTransient<IDoorTypeTable, DoorTypeTable>();
        collection.AddTransient<IDungeonPurposeTable, DungeonPurposeTable>();
        collection.AddTransient<IDungeonHistoryTable, DungeonHistoryTable>();
        collection.AddTransient<IFormOfGovernmentTable, FormOfGovernmentTable>();
        collection.AddTransient<IMonumentsTable, MonumentsTable>();
        collection.AddTransient<IPassageTable, PassageTable>();
        collection.AddTransient<IPassageTable, PassageTable>();
        collection.AddTransient<IPassageWidthTable, PassageWidthTable>();
        collection.AddTransient<IStartingAreaTable, StartingAreaTable>();
        collection.AddTransient<IWeirdLocalesTable, WeirdLocalesTable>();
        collection.AddTransient<IWorldShakingEventsTable, WorldShakingEventsTable>();

        return collection;
    }
}
