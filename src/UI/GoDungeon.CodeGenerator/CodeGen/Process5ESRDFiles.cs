using System.Diagnostics;
using System.Security.AccessControl;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Spells.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public class Process5ESRDFiles : IProcess5ESRDFiles
{
    /// <summary>
    /// Process the 5th edition SRD markDown files
    /// </summary>
    /// <param name="parseMonsterMarkdown">The parser file</param>
    /// <param name="generateMonster">The class generator</param>
    /// <param name="generateHtml">The .html generator</param>
    public Process5ESRDFiles
    (
        IParseMarkdown parseMarkdown,
        IGenerateModel generateMonster,
        IGenerateHtml generateHtml
    )
    {
        ParseMarkdown = parseMarkdown;
        GenerateModel = generateMonster;
        GenerateHtml = generateHtml;
    }

    /// <summary>
    /// the list of MarkDownTables.
    /// </summary>
    public List<IMarkDownTableModel> MarkDownTableModels = new List<IMarkDownTableModel>();

    /// <summary>
    /// Process monster files from the SRD
    /// </summary>
    public IParseMarkdown ParseMarkdown { get; }

    /// <summary>
    /// Generate the C# files for the monster
    /// </summary>
    public IGenerateModel GenerateModel { get; }

    /// <summary>
    /// Generate the .html file for the monster
    /// </summary>
    public IGenerateHtml GenerateHtml { get; }

    /// <summary>
    /// The root directory to generate the .html and class files in
    /// </summary>
    public string? RootMarkDownDirectory { get; set; }

    /// <summary>
    /// The root directory to generate the .html and class files in
    /// </summary>
    public string? RootOutputDirectory { get; set; }

    /// <summary>
    /// Process a directory
    /// </summary>
    /// <param name="rootDir">The root directory</param>
    public void ProcessDirectory(string inputDir, string outputdir)
    {
        RootMarkDownDirectory = inputDir;
        RootOutputDirectory = outputdir;
        ProcessDirectoryRecursive(inputDir, outputdir);
    }

    /// <summary>
    /// Process a directory recursively
    /// </summary>
    /// <param name="inputDir">The path to the input directory</param>
    /// <param name="outputDir">The path to the output directory</param>
    private void ProcessDirectoryRecursive(string inputDir, string outputDir)
    {
        foreach (var dir in Directory.EnumerateDirectories(inputDir))
        {
            ProcessDirectoryRecursive(dir, outputDir);
        }

        foreach (string filePath in Directory.EnumerateFiles(inputDir))
        {
            ProcessTables(filePath, outputDir);

            //if (filePath.Contains("spells") && filePath.EndsWith(".md"))
            //{
            //    ProcessSpellFile(filePath, outputdir);
            //}

            //if (filePath.Contains("monsters") && filePath.EndsWith(".md"))
            //{
            //    ProcessMonsterFile(filePath, outputdir);
            //}
        }
    }
    /// <summary>
    /// Process tables in the file
    /// </summary>
    /// <param name="filePath">The filePath to the markdown file</param>
    /// <param name="outputDir">The filePath to create the files</param>
    private void ProcessTables(string filePath, string outputDir)
    {
        var markDown = File.ReadAllLines(filePath).ToList();

        IMarkDownTableModel model = ParseMarkdown?.ParseMarkDownTable(markDown);
        if (model == null || !model.TableCaption.Any())
        {
            return;
        }

        var fileInfo = new FileInfo(filePath);
        string[] directories = fileInfo.DirectoryName.Split("\\");
        var OutputDir = $"{RootOutputDirectory}{filePath.Replace(RootMarkDownDirectory, string.Empty).Replace(Path.GetFileName(filePath), string.Empty)}";
        for (int i = 0; i < model.TableCaption.Count; i++)
        {
            var CSName = $"{Utilities.CleanupForCSharp(model.TableCaption[i])}";
            var tableName = model.TableCaption[i];
            var VMProperties = new List<string>();
            var propNames = model.TableRows[i][0].Split("|");
            foreach (var prop in propNames)
            {
                var fieldName = Utilities.CleanupForCSharp(prop.Replace("|", string.Empty).Trim());
                if (fieldName == string.Empty)
                {
                    continue;
                }
                VMProperties.Add(fieldName);
            }

            var row = new List<string>();
            for (int j = 2; j < model.TableRows[i].Count(); j++)
            {
                var cols = model.TableRows[i][j].Split("|");
                foreach (var col in cols)
                {
                    if (col == string.Empty)
                    {
                        continue;
                    }
                    var cleancol = Utilities.CleanupForCSharp(col?.Replace("|", string.Empty).Trim());
                    if (!string.IsNullOrEmpty(cleancol))
                    {
                        row.Add(cleancol);
                    }
                }

                // process the table
                GenerateModel.GenerateTable(outputDir, tableName, VMProperties, row, directories[directories.Length - 1]);
                row.Clear();
            }
        }
        return;
    }

    /// <summary>
    /// Process a spell file
    /// </summary>
    /// <param name="filePath">The filePath to the markdown file</param>
    /// <param name="outputDir">The filePath to create the files</param>
    private void ProcessSpellFile(string filePath, string outputDir)
    {
        var markDown = File.ReadAllLines(filePath).ToList();

        // Convert the file to .html
        if (markDown.Count >= 3)
        {
            var spell = ParseMarkdown?.ParseSpell(markDown);
            if (spell == null || string.IsNullOrEmpty(spell.Name))
            {
                Console.WriteLine($"Skipping file {filePath}");
                return;
            }

            // Convert the file to .html
            var htmlFile = $@"{outputDir}html\spells\{spell.Name}.html";
            Console.WriteLine($"Generating .html spell file {htmlFile}");
            using (StreamWriter writer = File.CreateText(htmlFile))
            {
                GenerateHtml.GenerateSpellHtmlFiles(writer, spell);
            }

            // Convert the file to a .cs interface
            var classFile = $@"{outputDir}models\spells\{spell.Name}.cs";
            using (StreamWriter writer = File.CreateText(classFile))
            {
                GenerateModel.GenerateSpellClass(writer, spell, outputDir);
            }
        }
    }

    /// <summary>
    /// Process a monster file
    /// </summary>
    /// <param name="filePath">The filePath to the markdown file</param>
    /// <param name="outputDir">The filePath to create the files</param>
    private void ProcessMonsterFile(string filePath, string outputDir)
    {
        var markDown = File.ReadAllLines(filePath).ToList();

        // Convert the file to .html
        if (markDown.Count >= 3)
        {
            var creature = ParseMarkdown.ParseMonster(markDown);
            if (creature == null || string.IsNullOrEmpty(creature.Name))
            {
                Console.WriteLine($"Skipping file {filePath}");
                return;
            }

            // Convert the file to .html
            var htmlFile = $@"{outputDir}Html\monsters\{creature.Name}.html";
            Console.WriteLine($"Generating .html file {htmlFile}");
            using (StreamWriter writer = File.CreateText(htmlFile))
            {
                GenerateHtml.GenerateMonsterHtmlFiles(writer, creature);
            }

            // Convert the file to a .cs interface
            var classFile = $@"{outputDir}Models\monsters\{creature.Name}.cs";
            using (StreamWriter writer = File.CreateText(classFile))
            {
                GenerateModel.GenerateMonsterClass(writer, creature, outputDir);
            }
        }
    }
}
