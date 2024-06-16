using System.ComponentModel;

using GoDungeon.Background;
using GoDungeon.Character;
using GoDungeon.Core;
using GoDungeon.Equipment;
using GoDungeon.Gaming;
using GoDungeon.MagicItems;
using GoDungeon.Monsters;
using GoDungeon.PDFParser.CodeGenerator;
using GoDungeon.PDFParser.interfaces;
using GoDungeon.RandomDungeon;
using GoDungeon.Spells;

namespace GoDungeon.PDFParser;

public class Program
{
    public static void Main(string[] args)
    {
        // Syncfusion License
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(Environment.GetEnvironmentVariable("SyncfusionLicense"));

        var builder = Host.CreateApplicationBuilder(args);

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
            .AddHostedService<Worker>()
            .AddSingleton<IProcessPDFFiles, ProcessPDFFiles>()
            .BuildServiceProvider();

        // finish out the builder
        var host = builder.Build();

        // run the background worker
        Console.WriteLine("Starting");
        host.Run();
        Console.WriteLine("Stopping");
    }
}