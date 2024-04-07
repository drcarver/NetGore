using CommunityToolkit.Maui;

using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;
using NetGore.Data;
using NetGore.ViewModel;

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
            .AddSingleton<MainPage, MainViewModel>()
            .UseNetGoreData()
            .UseNetGoreUIAdmin()
            //.AddSingletonWithShellRoute<MainPage, MainViewModel>("")
            .BuildServiceProvider();

        // all done
        return builder.Build();
    }
}
