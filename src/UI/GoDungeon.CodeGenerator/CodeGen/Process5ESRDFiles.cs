using System.Diagnostics;
using System.Runtime.InteropServices;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;

namespace GoDungeon.CodeGenerator.CodeGen;

public class Process5ESRDFiles : IProcess5ESRDFiles
{
    /// <summary>
    /// Process the 5th edition SRD markDown files
    /// </summary>
    /// <param name="parseMonsterMarkdown">The parser file</param>
    /// <param name="generateMonster">The class generator</param>
    /// <param name="generateHtml">The .html generator</param>
    /// <param name="generateView">The .maui view generator</param>
    public Process5ESRDFiles
    (
        IParseMarkdown parseMarkdown,
        IGenerateModel generateMonster,
        IGenerateHtml generateHtml,
        ILoggerFactory loggerFactory
    )
    {
        ParseMarkdown = parseMarkdown;
        GenerateModel = generateMonster;
        GenerateHtml = generateHtml;
        Logger = loggerFactory.CreateLogger<Process5ESRDFiles>();
    }

    /// <summary>
    /// The diagnostic logger
    /// </summary>
    private ILogger Logger { get; set; }

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
    /// The root directory for the source .md files
    /// </summary>
    public string? RootMarkDownDirectory { get; set; }

    /// <summary>
    /// The root directory to create the .html and class files
    /// </summary>
    public string? RootOutputDirectory { get; set; }

    /// <summary>
    /// Process a directory
    /// </summary>
    /// <param name="inputDir">The root directory</param>
    /// <param name="outputDir">The root directory</param>
    public void ProcessDirectory(string inputDir, string outputDir)
    {
        RootMarkDownDirectory = inputDir;
        RootOutputDirectory = outputDir;
        Logger.LogInformation($"Source={inputDir} Destination={outputDir}");
        var fileList = new List<string>();
        GetMarKDownFileListRecursive(inputDir, fileList);
        ProcessFileList(outputDir, fileList, inputDir);
        GenerateModel.GenerateXAMLFromMarkdown(outputDir, fileList, inputDir);
    }

    /// <summary>
    /// Get the fileList for the markdown
    /// </summary>
    /// <param name="inputDir">The input directory</param>
    /// <param name="fileList">The list of all files in the input directory structure</param>
    private void GetMarKDownFileListRecursive(string inputDir, List<string> fileList)
    {
        // Process each directory recursively 
        foreach (var dir in Directory.EnumerateDirectories(inputDir))
        {
            GetMarKDownFileListRecursive(dir, fileList);
        }

        // get a list of the files in the directory
        foreach (string filePath in Directory.EnumerateFiles(inputDir))
        {
            FileInfo fileInfo = new FileInfo(filePath);
            var outputFile = fileInfo.FullName.Replace(RootMarkDownDirectory, string.Empty);
            if (fileInfo.DirectoryName != RootMarkDownDirectory)
            {
                fileList.Add(outputFile);
            }
        }
        Logger.LogInformation($"Processing of {inputDir} Complete");
    }

    /// <summary>
    /// Generate all the files from the file list
    /// </summary>
    /// <param name="outputDir">The path to the output directory</param>
    /// <param name="fileList">The list of files</param>
    /// <param name="inputDir">The path to the input directory</param>
    private void ProcessFileList(string outputDir, List<string> fileList, string inputDir)
    {
        foreach (string filePath in fileList)
        {
            // Process all the tables in the SRD
            var inputFilePath = Path.Combine(inputDir, filePath.Substring(1));
            ProcessTables(inputFilePath, outputDir);

            // Process the monsters
            if (filePath.Contains("monsters") && filePath.EndsWith(".md"))
            {
                ProcessMonsterFile(inputFilePath, outputDir);
            }

            // Process the spells
            if (filePath.Contains("spells") && filePath.EndsWith(".md"))
            {
                //ProcessSpellFile(inputFilePath, outputDir);
            }

            ProcessMarkDownFiles(inputFilePath, outputDir);

            Logger.LogInformation($"Completed processing of {filePath}");
        }
    }

    /// <summary>
    /// Convert all markdown files into xaml
    /// </summary>
    /// <param name="filePath">The input file</param>
    /// <param name="outputDir">The output directory root</param>
    private void ProcessMarkDownFiles(string filePath, string outputDir)
    {
        var fileInfo = new FileInfo(filePath);
        if (fileInfo.Name == "index.md")
        {
            return;
        }

        // Create the directory structure to match the file location
        outputDir = $@"{outputDir}\Markdown";
        Directory.CreateDirectory(outputDir);
        var markDown = File.ReadAllLines(filePath).ToList();

        // Generate the equivalent xaml for the markdown file
        GenerateModel.GenerateXAMLFromMarkdown(outputDir, markDown, filePath);
    }

    /// <summary>
    /// Process tables in the file
    /// </summary>
    /// <param name="filePath">The filePath to the markdown file</param>
    /// <param name="outputDir">The filePath to create the files</param>
    private void ProcessTables(string filePath, string outputDir)
    {
        var fileInfo = new FileInfo(filePath);
        if (fileInfo.Name == "index.md")
        {
            return;
        }

        var markDown = File.ReadAllLines(filePath).ToList();
        IMarkDownTableModel model = ParseMarkdown?.ParseMarkDownTable(markDown);
        if (model == null || !model.TableCaption.Any())
        {
            return;
        }

        // Generate the tables and all supporting files
        string[] directories = fileInfo.DirectoryName.Split("\\");
        var OutputDir = $"{RootOutputDirectory}{filePath.Replace(RootMarkDownDirectory, string.Empty).Replace(Path.GetFileName(filePath), string.Empty)}";
        model.FilePath = filePath;
        for (int i = 0; i < model.TableCaption.Count; i++)
        {
            var CSName = $"{Utilities.CleanupForCSharp(model.TableCaption[i])}";
            var tableName = model.TableCaption[i];
            var VMProperties = new List<PropertyModel>();
            var propNames = model.TableRows[i][0].Split("|");
            if (i >= model.TableRows.Count() || i < 0 || model.TableRows[i].Count() < 3)
            {
                continue;
            }
            var propValues = model.TableRows[i][2].Split("|");
            for (int propcnt = 0; propcnt < propNames.Length; propcnt++)
            {
                var fieldName = Utilities.CleanupForCSharp(propNames[propcnt].Replace("|", string.Empty).Trim());
                var fieldVal = propValues[propcnt].Replace("|", string.Empty).Trim();
                if (string.IsNullOrEmpty(fieldName?.Trim()))
                {
                    continue;
                }
                VMProperties.Add(new PropertyModel 
                {
                    Name = fieldName, 
                    Value = "string" 
                });
                int intvalue;
                Decimal decvalue;
                if (int.TryParse(fieldVal, out intvalue))
                {
                    VMProperties[VMProperties.Count-1].Value = "int";
                }
                else if (Decimal.TryParse(fieldVal, out decvalue))
                {
                    VMProperties[VMProperties.Count - 1].Value = "decimal";
                }
            }

            var rows = new List<List<string>>();
            for (int j = 2; j < model.TableRows[i].Count(); j++)
            {
                var cols = model.TableRows[i][j].Split("|");
                var row = new List<string>();
                for (int colno = 0; colno < cols.Length; colno++)
                {
                    if (cols[colno].Trim() == string.Empty)
                    {
                        continue;
                    }
                    var cleancol = cols[colno]?.Replace("|", string.Empty).Trim();
                    if (!string.IsNullOrEmpty(cleancol))
                    {
                        row.Add(cleancol);
                    }
                }
                rows.Add(row);
            }

            // process the table
            GenerateModel.GenerateTable(outputDir, filePath, tableName, VMProperties, rows, Utilities.CleanupForCSharp(directories[directories.Length - 1]));
            rows.Clear();
        }

        // Generate the constructor for the main view model
        GenerateModel.GenerateConstructor(outputDir, model, filePath, markDown);
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
            var htmlFile = $@"{outputDir}\monsters\html\{creature.Name}.html";
            var fileInfo = new FileInfo(htmlFile);
            if (fileInfo != null)
            {
                Directory.CreateDirectory(fileInfo.DirectoryName);
            }
            Console.WriteLine($"Generating .html file {htmlFile}");
            using (StreamWriter writer = File.CreateText(htmlFile))
            {
                GenerateHtml.GenerateMonsterHtmlFiles(writer, creature);
            }

            // Convert the file to a .cs interface
            var classFile = $@"{outputDir}monsters\ViewModels\{creature.Name}.cs";
            fileInfo = new FileInfo(classFile);
            if (fileInfo != null)
            {
                Directory.CreateDirectory(fileInfo.DirectoryName);
            }
            Console.WriteLine($"Generating .cs file {classFile}");
            using (StreamWriter writer = File.CreateText(classFile))
            {
                GenerateModel.GenerateMonsterClass(writer, creature, outputDir);
            }
        }
    }
}
