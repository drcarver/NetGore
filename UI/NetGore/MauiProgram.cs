using Microsoft.Extensions.Logging;

using NetGore.Core.Interfaces;
using NetGore.Core.Models;
using NetGore.Data.Interfaces;
using NetGore.Data.Services;
using CommunityToolkit.Maui;

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
            var services = new ServiceCollection()
                //.AddSingleton<IExampleService, ExampleService>()
                .AddSingleton<IRaceService, RaceService>()
                .AddSingleton<ICharacterService, CharacterService>()
                .AddSingleton<IClassService, ClassService>()
                .AddSingleton<IPlayerCharacter, PlayerCharacter>()
                .AddSingleton<IAccountService, AccountService>()
            //.AddDbContextPool<NETGoreDbContext>(options =>
            //    options.UseSqlite(configuration.GetConnectionString("DefaultConnection")))
            .BuildServiceProvider();

        return builder.Build();
    }
}
