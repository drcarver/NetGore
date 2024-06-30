using CommunityToolkit.Maui;

using GoDungeon.Background;
using GoDungeon.Character;
using GoDungeon.Core;
using GoDungeon.Equipment;
using GoDungeon.Gaming;
using GoDungeon.MagicItems;
using GoDungeon.MAUI.Core;
using GoDungeon.MAUI.PlayerCharacter;
using GoDungeon.MAUI.Interfaces;
using GoDungeon.MAUI.Tables;
using GoDungeon.MAUI.Views;
using GoDungeon.Monsters;
using GoDungeon.RandomDungeon;
using GoDungeon.Spells;

using Microsoft.Extensions.Logging;
using GoDungeon.MAUI.DungeonMap;
using Syncfusion.Maui.Core.Hosting;
using GoDungeon.MAUI.ViewModels;

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
            })

            // Configure syncfusion
            .ConfigureSyncfusionCore();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        // Services
        builder.Services
            .AddTransient<IMainViewModel, MainViewModel>()
            .AddSingletonWithShellRoute<MainPage, MainViewModel>(nameof(MainPage))
            .UseGoDungeonBackground()
            .UseGoDungeonCharacter()
            .UseGoDungeonCore()
            //.UseGoDungeonEquipment()
            .UseGoDungeonGaming()
            .UseGoDungeonMagicItems()
            .UseGoDungeonMonsters()
            .UseGoDungeonRandomDungeon()
            .UseGoDungeonSpells()

            // Now the MAUI files
            .UseGoDungeonMAUICore()
            .UseGoDungeonMAUIPlayerCharacter()
            .UseGoDungeonMAUIDungeonMap()
            .BuildServiceProvider();

        return builder.Build();
    }
}
