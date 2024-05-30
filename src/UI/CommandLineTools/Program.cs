using GoDungeon.Background;
using GoDungeon.Character;
using GoDungeon.CommandLineTools.Models;
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

            GenerateClasses(builder.Services);
        }

        private static void GenerateClasses(IServiceCollection services)
        {
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
                var classInfo = GetClassInfo(markDown);

                if (string.IsNullOrEmpty(classInfo.Name))
                {
                    Console.WriteLine($"Skipping file {filePath}");
                    return;
                }
                Console.WriteLine($"Generating file {filePath}");

                // Convert the file to .html
                var htmlFile = filePath.Replace(".md", ".html");
                using (StreamWriter writer = File.CreateText(htmlFile))
                {
                    GenerateHTML(markDown, writer, classInfo);
                }

                // Convert the file to a .cs model
                var classFile = $@"C:\Users\drcarver\Desktop\NetGore\src\monsters\{classInfo.Name}.cs";
                using (StreamWriter writer = File.CreateText(classFile))
                {
                    GenerateClassHeader(classInfo, writer);
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
        private static void GenerateHTML(string[] markDown, StreamWriter writer, ClassInfo classInfo)
        {
            // Convert the MarkDown file to .html
            GenerateHtmlHeader(classInfo, writer);
            GenerateHtmlBody(classInfo, markDown, writer);
            GenerateHtmlEnd(writer);
        }

        /// <summary>
        /// Decode the classInfo from the start of the file
        /// </summary>
        /// <param name="markDown">The lines in the file</param>
        /// <returns>A ClassInfo</returns>
        private static ClassInfo GetClassInfo(string[] markDown)
        {
            ClassInfo classInfo = new();
            foreach (string line in markDown)
            {
                var fields = line.Split(':');
                if (fields.Length != 2)
                {
                    continue;
                }
                if (fields[0].Trim() == "name")
                {
                    classInfo.Name = CleanupForCSharp(fields[1].Trim());
                    continue;
                }
                if (fields[0].Trim() == "type")
                {
                    classInfo.RaceType = fields[1].Trim();
                    continue;
                }
                if (fields[0].Trim() == "cr")
                {
                    classInfo.ChallengeRating = fields[1].Trim();
                    continue;
                }
            }
            return classInfo;
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
        private static void GenerateHtmlBody(ClassInfo classInfo, string[] markdown, TextWriter stream)
        {
            stream.WriteLine("\t<BODY>");
            int i = 0;
            do
            {
                GenerateHtml.GenerateHtmlHeader(markdown[i], stream, classInfo);
                i++;
            } while (i < markdown.Length);
            stream.WriteLine("\t</BODY>");
        }

        private static void GenerateHtmlHeader(ClassInfo htmlFile, TextWriter stream)
        {
            stream.WriteLine("<!DOCTYPE html>");
            stream.WriteLine("<html>");
            stream.WriteLine("<head>");
            stream.WriteLine($"\t<title>{htmlFile.Name}</title>");
            stream.WriteLine("</head>");
        }
        #endregion

        /// <summary>
        /// Generate the class header
        /// </summary>
        /// <param name="filePath">Path to the file</param>
        private static void GenerateClassHeader(ClassInfo classInfo, TextWriter stream)
        {
            stream.WriteLine($"// {classInfo.Name}");
            stream.WriteLine("//");
            stream.WriteLine("using GoDungeon.Core.Enum;");
            stream.WriteLine("using GoDungeon.Core.ViewModels;");
            stream.WriteLine();
            stream.WriteLine("using Microsoft.Extensions.Logging;");
            stream.WriteLine();
            stream.WriteLine($"namespace GoDungeon.Monsters;");
            stream.WriteLine();
            stream.WriteLine($"public partial class {classInfo.Name} : CreatureViewModel");
            stream.WriteLine("{");
            stream.WriteLine($"\t/// <summary>");
            stream.WriteLine($"\t/// Constructor");
            stream.WriteLine($"\t/// </summary>");
            stream.WriteLine($"\t/// <param name=\"services\">The collection of services from the DI</param>");
            stream.WriteLine($"\t/// <param name=\"logger\">The logger factory from the DI</param>");
            stream.WriteLine($"\tpublic {classInfo.Name}(");
            stream.WriteLine("\t\tIServiceProvider services,");
            stream.WriteLine("\t\tILoggerFactory logger)");
            stream.WriteLine("\t\t: base(services, logger)");
            stream.WriteLine("\t{");
            stream.WriteLine($"\t\tName = nameof({classInfo.Name});");
            stream.WriteLine($"\t\tRaceType = RaceTypeEnum.{classInfo.RaceType};");
            stream.WriteLine($"\t\tChallengeRating = {classInfo.ChallengeRating};");
            //stream.WriteLine($"\t\tExperiencePoints = {classInfo.ExperiencePoints}");
            stream.WriteLine("\t}");
            stream.WriteLine("}");
        }
    }
}
//static void Main(string[] args)
//{

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

