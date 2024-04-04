using CommunityToolkit.Maui;
using CommunityToolkit.Mvvm.DependencyInjection;

using Microsoft.Extensions.Logging;

using NetGore.Data;

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
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
            });
#if DEBUG
            builder.Logging.AddDebug();
#endif
        // Services
        Ioc.Default.ConfigureServices(
            new ServiceCollection()
                .UseNetGoreData()
                .UseNetGoreUIAdmin()
                .BuildServiceProvider());

        return builder.Build();
    }
}
