using CommunityToolkit.Maui;

using GoDungeon.Background;
using GoDungeon.Character;
using GoDungeon.Core;
using GoDungeon.Equipment;
using GoDungeon.Gaming;
using GoDungeon.MagicItems;
using GoDungeon.MAUI.Background;
using GoDungeon.MAUI.Core;
using GoDungeon.MAUI.Core.Tables;
using GoDungeon.MAUI.Core.Views;
using GoDungeon.MAUI.Interfaces;
using GoDungeon.MAUI.Tables;
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
            .AddTransient<IMainMenuTable, MainMenuTable>()
            .AddSingletonWithShellRoute<MainPage, MainMenuTable>(nameof(MainPage))
            .UseGoDungeonBackground()
            .UseGoDungeonCharacter()
            .UseGoDungeonCore()
            .UseGoDungeonEquipment()
            .UseGoDungeonGaming()
            .UseGoDungeonMagicItems()
            .UseGoDungeonMonsters()
            .UseGoDungeonSpells()

            // Now the MAUI files
            .UseGoDungeonMAUICore()
            .UseGoDungeonMAUIBackground()

            .BuildServiceProvider();


        return builder.Build();
    }
}
