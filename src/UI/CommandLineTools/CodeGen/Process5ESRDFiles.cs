using GoDungeon.CommandLineTools.Interfaces;
using GoDungeon.CommandLineTools.Models;

namespace GoDungeon.CommandLineTools.CodeGen;

internal class Process5ESRDFiles : IProcess5ESRDFiles
{
    public Process5ESRDFiles
    (
        IParseMonsterMarkdown parseMonsterMarkdown,
        IGenerateMonster generateMonster,
        IGenerateHtml generateHtml
    )
    {
        ParseMonsterMarkdown = parseMonsterMarkdown;
        GenerateMonster = generateMonster;
        GenerateHtml = generateHtml;
    }

    /// <summary>
    /// Process monster files from the SRD
    /// </summary>
    public IParseMonsterMarkdown ParseMonsterMarkdown { get; }

    /// <summary>
    /// Generate the C# files for the monster
    /// </summary>
    public IGenerateMonster GenerateMonster { get; }

    /// <summary>
    /// Generate the .html file for the monster
    /// </summary>
    public IGenerateHtml GenerateHtml { get; }

    /// <summary>
    /// The root directory to generate the .html and class files in
    /// </summary>
    private string? MonsterRootDirectory { get; set; }

    /// <summary>
    /// Process a directory
    /// </summary>
    /// <param name="rootDir">The root directory</param>
    public void ProcessDirectory(string rootDir)
    {
        MonsterRootDirectory = rootDir;
        foreach (var dir in Directory.EnumerateDirectories(rootDir))
        {
            ProcessDirectory(dir);
        }

        foreach (string filePath in Directory.EnumerateFiles(rootDir))
        {
            if (filePath.Contains("monsters") && filePath.EndsWith(".md"))
            {
                ProcessFile(filePath);
            }
        }
    }

    /// <summary>
    /// Process a file
    /// </summary>
    /// <param name="filePath">The filePath to create the file</param>
    private void ProcessFile(string filePath)
    {
        var markDown = File.ReadAllLines(filePath).ToList();

        // Convert the file to .html
        if (markDown.Count >= 3)
        {
            ParseMonsterMarkdown.ParseMonster(markDown);
            if (string.IsNullOrEmpty(monsterInfo.Name))
            {
                Console.WriteLine($"Skipping file {filePath}");
                return;
            }

            // Convert the file to .html
            var htmlFile = filePath.Replace(".md", ".html");
            Console.WriteLine($"Generating .html file {filePath}");
            using (StreamWriter writer = File.CreateText(htmlFile))
            {
                GenerateHtml.GenerateHtmlFile(writer);
            }

            // Convert the file to a .cs model
            var classFile = $@"{MonsterRootDirectory}Models/{monsterInfo.Name}.cs";
            using (StreamWriter writer = File.CreateText(classFile))
            {
                GenerateMonster.GenerateHeader(writer);
            }
            // Convert the file to a .cs interface
            var interfaceFile = $@"{MonsterRootDirectory}Interfaces/I{monsterInfo.Name}.cs";
            using (StreamWriter writer = File.CreateText(interfaceFile))
            {
                writer.WriteLine("//");
                writer.WriteLine($"// {monsterInfo.ProperName}.");
                writer.WriteLine("//");
                writer.WriteLine("using GoDungeon.Core.Interfaces;");
                writer.WriteLine();
                writer.WriteLine("namespace GoDungeon.Monsters.Interfaces");
                writer.WriteLine("{");
                writer.WriteLine("\t/// <summary>");
                writer.WriteLine($"\t/// {monsterInfo.ProperName}.");
                writer.WriteLine($"\t/// </summary>");
                writer.WriteLine($"\tpublic interface I{monsterInfo.Name} : ICreature");
                writer.WriteLine("\t{");
                writer.WriteLine("\t}");
                writer.WriteLine("}");
            }
        }
    }
}
