using CommunityToolkit.Maui;

using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using NetGore.Data;
using NetGore.ViewModel;
using D20.Core;
using D20.Character;
using NetGore.Interfaces;
using NetGore.Tables;
using NetGore.Views;

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
            .AddScopedWithShellRoute<MainPage, MainPageViewModel>(nameof(MainPage))
            .UseD20Core()
            //.UseD20Character()
            //.UseD20Data()
            //.UseD20Goods()
            //.UseD20MagicItems()
            .UseNetGoreUIAdmin()
            .BuildServiceProvider();

        // all done
        return builder.Build();
    }
}
