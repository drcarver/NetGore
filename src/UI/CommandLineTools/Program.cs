
//using GoDungeon.Background;
//using GoDungeon.Character;
//using GoDungeon.Core;
//using GoDungeon.Equipment;
//using GoDungeon.Gaming;
//using GoDungeon.MagicItems;
//using GoDungeon.MAUI.Core;
//using GoDungeon.MAUI.PlayerCharacter;
//using GoDungeon.MAUI.Interfaces;
//using GoDungeon.MAUI.Tables;
//using GoDungeon.MAUI.Views;
//using GoDungeon.Monsters;
//using GoDungeon.RandomDungeon;
//using GoDungeon.Spells;

//using Microsoft.Extensions.Logging;
//using GoDungeon.MAUI.DungeonMap;
//using Syncfusion.Maui.Core.Hosting;
//using Syncfusion.DocIO.DLS;
//using Syncfusion.DocIO;
//using GoDungeon.Core.ViewModels;

//namespace CommandLineTools;

internal class Program
{
    static void Main(string[] args)
{
        //        // Syncfusion License
        //        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Ngo9BigBOggjHTQxAR8/V1NBaF5cXmZCf1FpRmJGdld5fUVHYVZUTXxaS00DNHVRdkdnWXpcdXVURWNdVk13W0Q=");


        //        foreach (var file in Directory.EnumerateFiles(@"C:\Users\drcarver\Desktop\NetGore\src\UI\CommandLineTools\docs\"))
        //        {
        //            if (file.EndsWith(".md"))
        //            {
        //                using (var reader = new StreamReader(file))
        //                {
        //                    //Load the file stream into a Word document.
        //                    using (WordDocument document = 
        //                        new WordDocument(reader.BaseStream, FormatType.Html))
        //                    {
        //                        ConvertFile(file, document);
        //                    }
        //                }
        //            }
    }
}

//    static void ConvertFile(string filePath, WordDocument doc)
//    {
//        var md = File.ReadAllText(filePath);

//        // Convert to .md
//        string fileName = filePath.Replace(".md", ".html");
//        using (var stream = File.OpenWrite(fileName))
//        {
//            doc.Save(stream, FormatType.Html);
//        }

//        fileName = filePath.Replace(".md", ".wml");
//        using (var stream = File.OpenWrite(fileName))
//        {
//            doc.Save(stream, FormatType.WordML);
//        }

//        //var creature = new CreatureViewModel()
//    }

//public static class MauiProgram
//{
//    public static MauiApp CreateMauiApp()
//    {
//        var builder = MauiApp.CreateBuilder();
//        builder
//            .UseMauiApp<App>()
//            // Initialize the .NET MAUI Community Toolkit by
//            // adding the below line of code
//            .UseMauiCommunityToolkit()

//            .ConfigureFonts(fonts =>
//            {
//                fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
//                fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
//            })

//            // Configure syncfusion
//            .ConfigureSyncfusionCore();

//#if DEBUG
//        builder.Logging.AddDebug();
//#endif

//        // Services
//        builder.Services
//            .AddTransient<IMainMenuTable, MainMenuTable>()
//            .AddSingletonWithShellRoute<MainPage, MainMenuTable>(nameof(MainPage))
//            .UseGoDungeonBackground()
//            .UseGoDungeonCharacter()
//            .UseGoDungeonCore()
//            .UseGoDungeonEquipment()
//            .UseGoDungeonGaming()
//            .UseGoDungeonMagicItems()
//            .UseGoDungeonMonsters()
//            .UseGoDungeonRandomDungeon()
//            .UseGoDungeonSpells()

//            // Now the MAUI files
//            .UseGoDungeonMAUICore()
//            .UseGoDungeonMAUIPlayerCharacter()
//            .UseGoDungeonMAUIDungeonMap()
//            .BuildServiceProvider();

//        return builder.Build();
//    }
//}

//}
