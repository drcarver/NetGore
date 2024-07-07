using CommunityToolkit.Maui;

using GoDungeon.MAUI.Equipment.Interfaces;
using GoDungeon.MAUI.Equipment.ViewModels;
using GoDungeon.MAUI.Equipment.Views;

namespace GoDungeon.MAUI.Equipment
{
    public static class DataServices
    {
        /// <summary>
        /// The GoDungeon Core tables and services
        /// </summary>
        /// <param name="collection">The DI service collection</param>
        /// <returns>The services collection</returns>
        public static IServiceCollection UseGoDungeonMAUIEquipment(this IServiceCollection collection)
        {
            collection
                // Add all the view models as transient
                .AddTransient<IBetweenAdventuresViewModel, BetweenAdventuresViewModel>()
                .AddTransient<IMovementViewModel, MovementViewModel>()

                // The tables
                .AddTransient<IAdventuringTableViewModel, AdventuringTableViewModel>()

                // Add the menu table Views
                .AddTransientWithShellRoute<AdventuringTableView, AdventuringTableViewModel>(nameof(AdventuringTableView))

                // Register additional detail routes
                .AddTransientWithShellRoute<BetweenAdventuresView, BetweenAdventuresViewModel>(nameof(BetweenAdventuresView))
                .AddTransientWithShellRoute<MovementView, MovementViewModel>(nameof(MovementView))
                ;
            Routing.RegisterRoute(nameof(MovementView), typeof(MovementView));
  
            return collection;
        }
    }
}
