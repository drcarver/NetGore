using System.Reflection;

using CommunityToolkit.Maui;

using GoDungeon.Core.Tables;
using GoDungeon.MAUI.DungeonMap.Interfaces;
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
            .AddTransient<IGridLines, GridLinesViewModel>()

            // Add the views
            .AddTransientWithShellRoute<DungeonMapPage, DungeonMapViewModel>(nameof(DungeonMapPage))
            ;

        return collection;
    }
}
