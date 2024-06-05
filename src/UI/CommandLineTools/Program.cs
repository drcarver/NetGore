using GoDungeon.Background;
using GoDungeon.Character;
using GoDungeon.CommandLineTools.CodeGen;
using GoDungeon.Core;
using GoDungeon.Equipment;
using GoDungeon.Gaming;
using GoDungeon.MagicItems;
using GoDungeon.Monsters;
using GoDungeon.RandomDungeon;
using GoDungeon.Spells;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace GoDungeon.CommandLineTools
{
    public class Program
    {
        public const string MONSTERROOT = $@"C:\Users\drcarver\Desktop\monsters\";

        /// <summary>
        /// The main program
        /// </summary>
        /// <param name="args">The arguments to the program</param>
        /// <returns>A Task for the main program</returns>
        static Task Main(string[] args)
        {
            // Syncfusion License
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXpcdXVURWNdVk13W0Q=");

            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services
                .UseGoDungeonCore()
                .UseGoDungeonBackground()
                .UseGoDungeonCharacter()
                .UseGoDungeonEquipment()
                .UseGoDungeonGaming()
                .UseGoDungeonMagicItems()
                .UseGoDungeonMonsters()
                .UseGoDungeonRandomDungeon()
                .UseGoDungeonSpells()
                .UseGoDungeonCommandLineTools()
                .BuildServiceProvider();

            builder.Build();

            //Console.WriteLine("starting");
            //var app = host.Services.GetRequiredService<TestApp>();
            //await app.RunAsync();
            //Console.WriteLine("stopped");
            //Host.
            //builder.Services.Get
            //GenerateClasses();
            //return Task.CompletedTask;
        }
    }
}
//public class Program
//{
//    public static async Task Main(string[] args)
//    {



//    }

//    private static IHostBuilder CreateDefaultApp(string[] args)
//    {
//        var builder = Host.CreateDefaultBuilder();
//        builder.ConfigureServices(conf =>
//        {
//            conf.AddSingleton<TestApp>();
//        });
//        builder.ConfigureLogging(conf =>
//        {
//            conf.ClearProviders();
//            conf.AddConsole();
//        });
//        builder.UseConsoleLifetime();

//        return builder;
//    }
//}

//public class TestApp
//{
//    private readonly IHostLifetime _lifetime;
//    private readonly IHostApplicationLifetime _appLifetime;

//    public TestApp(IHostLifetime lifetime, IHostApplicationLifetime appLifetime)
//    {
//        _lifetime = lifetime;
//        _appLifetime = appLifetime;
//    }

//    public async Task RunAsync()
//    {
//        var stopToken = _appLifetime.ApplicationStopping;

//        Console.WriteLine("RunAsync starting");
//        for (int i = 0; i < 10; i++)
//        {
//            if (stopToken.IsCancellationRequested)
//            {
//                Console.WriteLine("STOP");
//                break;
//            }

//            await Task.Delay(250);
//            Console.Write(i);
//        }

//        Console.WriteLine();
//        Console.WriteLine("RunAsync done");
//    }
//}
