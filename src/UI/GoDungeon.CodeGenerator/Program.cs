using GoDungeon.Background;
using GoDungeon.Character;
using GoDungeon.Core;
using GoDungeon.Equipment;
using GoDungeon.Gaming;
using GoDungeon.MagicItems;
using GoDungeon.Monsters;
using GoDungeon.RandomDungeon;
using GoDungeon.Spells;

namespace GoDungeon.CodeGenerator;

public class Program
{
    public static void Main(string[] args)
    {
        // Syncfusion License
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXpcdXVURWNdVk13W0Q=");

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
            .UseGoDungeonCodeGenerator()
            .AddHostedService<Worker>()
            .BuildServiceProvider();

        // finish out the builder
        var host = builder.Build();

        // run the background worker
        Console.WriteLine("Starting");
        host.Run();
        Console.WriteLine("Stopping");
    }
}