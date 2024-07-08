using System.Collections.Immutable;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.CodeGenerator.ViewModels;

namespace GoDungeon.CodeGenerator.CodeGen;

public class Process5ESRDFiles : IProcess5ESRDFiles
{
    /// <summary>
    /// Process the 5th edition SRD markDown files
    /// </summary>
    /// <param name="parseMarkdown">The parser file</param>
    /// <param name="generateModel">The class generator</param>
    /// <param name="generateHtml">The .html generator</param>
    /// <param name="generateView">The .maui view generator</param>
    public Process5ESRDFiles
    (
        IParseMarkdown parseMarkdown,
        IGenerateModel generateModel,
        IGenerateHtml generateHtml,
        ILoggerFactory loggerFactory
    )
    {
        ParseMarkdown = parseMarkdown;
        GenerateModel = generateModel;
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
    /// Process a directory
    /// </summary>
    /// <param name="inputDir">The root directory for the markdown files</param>
    public void ParseMarkdownDirectory(string inputDir)
    {
        RootMarkDownDirectory = inputDir;
        Logger.LogInformation($"Parse all markdown files in the Source={inputDir} Directory");
        var fileList = new List<string>();
        GetMarKDownFileListRecursive(inputDir, fileList);
        ProcessFileList(fileList);
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
    /// Process all the markdown files from the file list in Parse Models.
    /// </summary>
    /// <param name="fileList">The list of files</param>
    private void ProcessFileList(List<string> fileList)
    {
        foreach (string filePath in fileList)
        {
            // Parse markdown file
            ProcessMarkDownFile(filePath);
            Logger.LogDebug($"Completed parse of {filePath}");
        }
    }

    /// <summary>
    /// Convert all markdown files into a Parse Model
    /// </summary>
    /// <param name="filePath">The file containing the markdown</param>
    private void ProcessMarkDownFile(string filePath)
    {
        var markdown = ConvertMarkdownToParseModel(filePath);
        ICodeGen vm = null;
        switch (markdown.FileHeaders.Count)
        {
            // index files are ignored.  The will be replaced by TableViews
            // with Menu intent on all nodes that have a markdown file
            case 0:
                Logger.LogDebug($"Ignoring index file {filePath}");
                break;
            // Rules files have just a description line in the header
            case 1:
                Logger.LogDebug($"Converting markdown rules file {filePath} to ParseModel");
                vm = new RulesViewModel(markdown);
                break;
            // Magic Items have two header entries.  Name and type.
            case 2:
                Logger.LogDebug($"Converting markdown magic item file {filePath} to ParseModel");
                vm = new MagicItemViewModel(markdown);
                break;
            // Monsters have three header entries.  Name, type and challenge rating.
            case 3:
                Logger.LogDebug($"Converting markdown monster file {filePath} to ParseModel");
                vm = new MonsterViewModel(markdown);
                break;
            // spells have four header entries.  Name, school, level and character classes that can cast the spell.
            case 4:
                Logger.LogDebug($"Converting markdown spell file {filePath} to ParseModel");
                vm = new SpellViewModel(markdown);
                break;
        }
        if (vm != null)
        {
            ParseMarkdown.ParseMarkdownToHTML(vm.ParseModel);
            var fileInfo = new FileInfo(filePath);
            if (!string.IsNullOrEmpty(fileInfo.DirectoryName))
            {
                if (!ParseMarkdown.CodeGenModels.ContainsKey(fileInfo.DirectoryName))
                {
                    ParseMarkdown.CodeGenModels.Add(fileInfo.DirectoryName, []);
                }
                ParseMarkdown.CodeGenModels[fileInfo.DirectoryName].Add(vm);
            }
        }
    }

    /// <summary>
    /// Convert a markdown to a ParseModel
    /// </summary>
    /// <param name="filePath">The input file path</param>
    /// <returns>The parse model for the file</returns>
    private ParseModel ConvertMarkdownToParseModel(string filePath)
    {
        Logger.LogDebug($"Converting markdown {filePath} to ParseModel");

        // Initialize the parse model
        var fullPath = $"{RootMarkDownDirectory}{filePath}";
        Logger.LogDebug($"Read all the lines of the markdown file at {filePath} and construct a ParseModel");
        var parseModel = new ParseModel(filePath, File.ReadLines(fullPath).ToImmutableArray<string>());

        // process the tables in the markdown
        Logger.LogDebug($"Parse all the tables in the markdown file at {filePath}");
        ParseMarkdown?.ParseMarkDownTable(parseModel);

        return parseModel;
    }
}
