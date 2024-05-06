using System.Reflection;

using CommunityToolkit.Maui;

using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables;
using GoDungeon.Core.Tables;
using GoDungeon.MAUI.Background.Interfaces;
using GoDungeon.MAUI.Background.Tables;
using GoDungeon.MAUI.Background.Views;

namespace GoDungeon.MAUI.Core
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        public static List<Type> MAUIBackgroundTables => Assembly
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
        public static IServiceCollection UseGoDungeonMAUIBackground(this IServiceCollection collection)
        {
            //collection
            // The menu pages (not in the shell)
            //collection.AddTransientWithShellRoute<BackgroundMenuTablePage, BackgroundMenuTable>(nameof(BackgroundMenuTablePage));
            //collection.AddTransientWithShellRoute<RacialBackgroundMenuTablePage, RacialBackgroundMenuTable>(nameof(RacialBackgroundMenuTablePage));

            // Add the menu tables
            collection.AddTransient<IBackgroundMenuTable, BackgroundMenuTable>();
            collection.AddTransient<IRacialBackgroundMenuTable, RacialBackgroundMenuTable>();

            // Register additional detail routes
            Routing.RegisterRoute(nameof(BackgroundTablePage), typeof(BackgroundTablePage));
            Routing.RegisterRoute(nameof(ConflictTablePage), typeof(ConflictTablePage));

            return collection;
        }
    }
}
