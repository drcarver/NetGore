using CommunityToolkit.Maui;

using D20.Character;
using D20.Core;
using D20.Goods;
using D20.MagicItems;
using D20.Monsters;
using D20.Spells;

using Microsoft.Extensions.Logging;

using NetGore.Data;
using NetGore.Interfaces;
using NetGore.Tables;
using NetGore.ViewModel;
using NetGore.Views;

using Syncfusion.Maui.Core.Hosting;

namespace NetGore;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .UseMauiCommunityToolkitMediaElement()
            .ConfigureSyncfusionCore()
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
            .AddSingleton<IMainNavigationTable, MainNavigationTable>()
            .AddSingletonWithShellRoute<MainPage, MainPageViewModel>(nameof(MainPage))
            .UseD20Core()
            .UseD20Character()
            //.UseD20Data()
            .UseD20Goods()
            .UseD20MagicItems()
            .UseD20Monsters()
            .UseD20Spells()
            .UseNetGoreUIAdmin()
            .BuildServiceProvider();

        // all done
        return builder.Build();
    }
}
