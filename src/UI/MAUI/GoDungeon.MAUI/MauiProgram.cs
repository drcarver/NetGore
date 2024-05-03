using CommunityToolkit.Maui;

using GoDungeon.Background;
using GoDungeon.Character;
using GoDungeon.Core;
using GoDungeon.Equipment;
using GoDungeon.Gaming;
using GoDungeon.MagicItems;
using GoDungeon.MAUI.ViewModels;
using GoDungeon.MAUI.Views;
using GoDungeon.Monsters;
using GoDungeon.Spells;

using Microsoft.Extensions.Logging;

namespace GoDungeon.MAUI;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            // Initialize the .NET MAUI Community Toolkit by
            // adding the below line of code
            .UseMauiCommunityToolkit()

            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        // Services
        builder.Services
            //.AddSingleton<IMainNavigationTable, MainNavigationTable>()
            .AddSingletonWithShellRoute<MainPage, MainPageViewModel>(nameof(MainPage))
            .UseGoDungeonBackground()
            .UseGoDungeonCharacter()
            .UseGoDungeonCore()
            .UseGoDungeonEquipment()
            .UseGoDungeonGaming()
            .UseGoDungeonMagicItems()
            .UseGoDungeonMonsters()
            .UseGoDungeonSpells()

            .BuildServiceProvider();


        return builder.Build();
    }
}
