using GoDungeon.Background;
using GoDungeon.Character;
using GoDungeon.CommandLineTools.CodeGen;
using GoDungeon.Core;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
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
    internal class Program
    {
        internal static IServiceCollection Services {get; set; }
        internal static ICreature Creature { get; set; }
        internal const string MONSTERROOT = $@"C:\Users\drcarver\Desktop\monsters\";


        static async Task Main(string[] args)
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
            .BuildServiceProvider();

            builder.Build();

            Services = builder.Services;

            GenerateClasses();
        }

        /// <summary>
        /// Generate the c# classes
        /// </summary>
        private static void GenerateClasses()
        {
            const string ROOTDIR = @"..\..\..\docs";
            ProcessDirectory(ROOTDIR);
            GenerateMonster.GenerateLists();
        }

        /// <summary>
        /// Process a directory
        /// </summary>
        /// <param name="rootDir">The rootdir of the directory</param>
        private static void ProcessDirectory(string rootDir)
        {
            foreach (var dir in Directory.EnumerateDirectories(rootDir))
            {
                ProcessDirectory(dir);
            }

            foreach (string filePath in Directory.EnumerateFiles(rootDir))
            {
                if (filePath.EndsWith(".md"))
                {
                    ProcessFile(filePath);
                }
            }
        }

        /// <summary>
        /// Process a file
        /// </summary>
        /// <param name="filePath">The filePath to create the file</param>
        private static void ProcessFile(string filePath)
        {
            var markDown = File.ReadAllLines(filePath).ToList();

            // Convert the file to .html
            if (filePath.Contains("monsters") && markDown.Count >= 3)
            {
                ParseMarkdown.ParseMonster(markDown);
                if (string.IsNullOrEmpty(Creature.Name))
                {
                    Console.WriteLine($"Skipping file {filePath}");
                    return;
                }
                Console.WriteLine($"Generating file {filePath}");

                // Convert the file to .html
                var htmlFile = filePath.Replace(".md", ".html");
                using (StreamWriter writer = File.CreateText(htmlFile))
                {
                    GenerateHtml.GenerateHtmlFile(markDown, writer);
                }

                // Convert the file to a .cs model
                var classFile = $@"{MONSTERROOT}Models/{Creature.Name}.cs";
                using (StreamWriter writer = File.CreateText(classFile))
                {
                    GenerateMonster.GenerateHeader(writer);
                }
                // Convert the file to a .cs interface
                var interfaceFile = $@"{MONSTERROOT}Interfaces/I{Creature.Name}.cs";
                using (StreamWriter writer = File.CreateText(interfaceFile))
                {
                    writer.WriteLine("//");
                    writer.WriteLine($"// {Program.Creature.ProperName}.");
                    writer.WriteLine("//");
                    writer.WriteLine("using GoDungeon.Core.Interfaces;");
                    writer.WriteLine();
                    writer.WriteLine("namespace GoDungeon.Monsters.Interfaces");
                    writer.WriteLine("{");
                    writer.WriteLine("\t/// <summary>");
                    writer.WriteLine($"\t/// {Program.Creature.ProperName}.");
                    writer.WriteLine($"\t/// </summary>");
                    writer.WriteLine($"\tpublic interface I{Program.Creature.Name} : ICreature");
                    writer.WriteLine("\t{");
                    writer.WriteLine("\t}");
                    writer.WriteLine("}");
                }
            }
        }
    }
}
