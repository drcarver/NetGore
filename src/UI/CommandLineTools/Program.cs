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
    internal class Program
    {
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

            const string ROOTDIR = @"..\..\..\docs";
            ProcessDirectory(ROOTDIR);
        }

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

        private static void ProcessFile(string filePath)
        {
            var markDown = File.ReadAllLines(filePath);

            // Convert the file to .html
            if (filePath.Contains("monsters") && markDown.Length >= 3)
            {
                ParseMarkdown.GetCreature();
                if (string.IsNullOrEmpty(ParseMarkdown.Creature?.Name))
                {
                    Console.WriteLine($"Skipping file {filePath}");
                    return;
                }
                Console.WriteLine($"Generating file {filePath}");

                // Convert the file to .html
                var htmlFile = filePath.Replace(".md", ".html");
                using (StreamWriter writer = File.CreateText(htmlFile))
                {
                    GenerateHTML(markDown, writer);
                }

                // Convert the file to a .cs model
                var classFile = $@"C:\Users\drcarver\Desktop\NetGore\src\monsters\{ParseMarkdown.Creature?.Name}.cs";
                using (StreamWriter writer = File.CreateText(classFile))
                {
                    GenerateMonster.GenerateClassHeader(writer);
                }
            }
        }

        #region Generate HTML
        /// <summary>
        /// Generate the .html for the class
        /// </summary>
        /// <param name="markDown">The markdown file as a series of strings</param>
        /// <param name="writer">The StreamWriter stream</param>
        /// <param name="classInfo">The ClassInfo file</param>
        private static void GenerateHTML(string[] markDown, StreamWriter writer)
        {
            // Convert the MarkDown file to .html
            GenerateHtmlHeader(writer);
            GenerateHtmlBody(markDown, writer);
            GenerateHtmlEnd(writer);
        }

        /// <summary>
        /// Clean up a string so it can be used as a C# variable
        /// </summary>
        /// <param name="name">The name to fix-up</param>
        /// <returns>The string as a c# variable name</returns>
        private static string? CleanupForCSharp(string name)
        {
            return name
                .Replace(" ", string.Empty)
                .Replace("/", string.Empty)
                .Replace("\\", string.Empty)
                .Trim();
        }

        /// <summary>
        /// Write the end of the .html file
        /// </summary>
        /// <param name="stream">The output stream</param>
        private static void GenerateHtmlEnd(TextWriter stream)
        {
            stream.WriteLine("</HTML>");
        }

        /// <summary>
        /// Generate the body of the .html file 
        /// </summary>
        /// <param name="htmlFile"></param>
        /// <param name="markdown"></param>
        /// <param name="stream"></param>
        private static void GenerateHtmlBody(string[] markdown, TextWriter stream)
        {
            stream.WriteLine("\t<BODY>");
            int i = 0;
            do
            {
                GenerateHtml.GenerateHtmlHeader(markdown[i], stream);
                i++;
            } while (i < markdown.Length);
            stream.WriteLine("\t</BODY>");
        }

        private static void GenerateHtmlHeader(TextWriter stream)
        {
            stream.WriteLine("<!DOCTYPE html>");
            stream.WriteLine("<html>");
            stream.WriteLine("<head>");
            stream.WriteLine($"\t<title>{ParseMarkdown.Creature?.ProperName}</title>");
            stream.WriteLine("</head>");
        }
        #endregion
    }
}
