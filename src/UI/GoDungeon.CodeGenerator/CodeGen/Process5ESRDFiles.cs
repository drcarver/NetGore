using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public class Process5ESRDFiles : IProcess5ESRDFiles
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
    public string? MonsterRootDirectory { get; set; }

    /// <summary>
    /// Process a directory
    /// </summary>
    /// <param name="rootDir">The root directory</param>
    public void ProcessDirectory(string inputDir, string outputdir)
    {
        MonsterRootDirectory = inputDir;
        foreach (var dir in Directory.EnumerateDirectories(inputDir))
        {
            ProcessDirectory(dir, outputdir);
        }

        foreach (string filePath in Directory.EnumerateFiles(inputDir))
        {
            if (filePath.Contains("monsters") && filePath.EndsWith(".md"))
            {
                ProcessFile(filePath, outputdir);
            }
        }
    }

    /// <summary>
    /// Process a file
    /// </summary>
    /// <param name="filePath">The filePath to create the file</param>
    private void ProcessFile(string filePath, string outputDir)
    {
        var markDown = File.ReadAllLines(filePath).ToList();

        // Convert the file to .html
        if (markDown.Count >= 3)
        {
            var creature = ParseMonsterMarkdown.ParseMonster(markDown);
            if (string.IsNullOrEmpty(creature.Name))
            {
                Console.WriteLine($"Skipping file {filePath}");
                return;
            }

            // Convert the file to .html
            var htmlFile = $@"{outputDir}Html\{creature.Name}.html";
            Console.WriteLine($"Generating .html file {htmlFile}");
            using (StreamWriter writer = File.CreateText(htmlFile))
            {
                GenerateHtml.GenerateHtmlFiles(writer, creature);
            }

            // Convert the file to a .cs interface
            var classFile = $@"{outputDir}Models\{creature.Name}.cs";
            using (StreamWriter writer = File.CreateText(classFile))
            {
                GenerateMonster.GenerateMonsterClass(writer, creature, outputDir);
            }
        }
    }
}
