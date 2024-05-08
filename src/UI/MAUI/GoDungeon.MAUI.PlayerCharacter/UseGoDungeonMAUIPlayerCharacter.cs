using System.Reflection;

using CommunityToolkit.Maui;

using GoDungeon.Core.Tables;
using GoDungeon.MAUI.PlayerCharacter.ViewModels;
using GoDungeon.MAUI.PlayerCharacter.Views;

namespace GoDungeon.MAUI.PlayerCharacter
{
    public static class DataServices
    {
        /// <summary>
        /// Get all the IGameable entries
        /// </summary>
        /// <returns></returns>
        public static List<Type> MAUICoreTables => Assembly
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
        public static IServiceCollection UseGoDungeonMAUIPlayerCharacter(this IServiceCollection collection)
        {
            //collection
            // Add all the game table types as transient
            //collection.AddTransient<ICoreMenuTable, CoreMenuTable>();

            //// The character sheet
            collection.AddTransientWithShellRoute<CreatePlayerCharacterPage, PlayerCharacterViewModel>(nameof(CreatePlayerCharacterPage));

            //// Add the menu tables
            //collection.AddTransient<IBackgroundMenuTable, BackgroundMenuTable>();
            //collection.AddTransient<IRacialBackgroundMenuTable, RacialBackgroundMenuTable>();

            //// Register additional detail routes
            //Routing.RegisterRoute(nameof(BackgroundTablePage), typeof(BackgroundTablePage));
            //Routing.RegisterRoute(nameof(ConflictTablePage), typeof(ConflictTablePage));
            //Routing.RegisterRoute(nameof(MenuTablePage), typeof(MenuTablePage));

            return collection;
        }
    }
}
