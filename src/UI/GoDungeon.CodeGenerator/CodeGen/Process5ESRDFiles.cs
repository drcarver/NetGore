using System.Collections.Immutable;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.CodeGenerator.ViewModels;
using GoDungeon.CommandLineTools.CodeGen;

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
    /// Parse markdown files from the SRD
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
        GenerateIndexFiles(fileList);
    }

    /// <summary>
    /// Generate the Index files.
    /// </summary>
    /// <param name="fileList">THe input dir for the indexes</param>
    private void GenerateIndexFiles(List<string> fileList)
    {
        var indexes = fileList
            .Where(i => (i.Contains("GamemasterRules") || i.Contains("spellcasting"))
                && i.EndsWith("index.md")).ToArray();
        for (int i = 0; i < indexes.Length; i++)
        {
            string fRoute = indexes[i].Replace("_", string.Empty);
            //var parseModel = CreateIndex(fRoute);
            //ICodeGen cgm = new CodeGenerationModel(indexFileNames[i].parseModel);
            //if (!ParseMarkdown.CodeGenModels.ContainsKey(indexFileNames[i].parseModel.Route))
            //{
            //    ParseMarkdown.CodeGenModels.Add(indexFileNames[i].parseModel.Route, []);
            //    ParseMarkdown.CodeGenModels[indexFileNames[i].parseModel.Route].Add(cgm);
            //}
            //else
            //{
            //    ParseMarkdown.CodeGenModels[indexFileNames[i].parseModel.Route].Add(cgm);
            //}
        }
    }

    /// <summary>
    /// Create the index parse model
    /// </summary>
    /// <param name="route">route to the index</param>
    /// <returns>The ParseModel for the index</returns>
    private ParseModel? CreateIndex(string route)
    {
        route = route.Replace("/index.md", string.Empty);
        if (!ParseMarkdown.CodeGenModels.Keys.Contains(route))
        {
            ParseMarkdown.CodeGenModels.Add(route.Replace("/index.md", string.Empty), []);
        }
        List<string> markdown = [];
        Dictionary<string, List<ICodeGen>> dictionaryIndex = new();
        ParseModel? parseModel = null;
        switch (route)
        {
            case "itemsbyname.md":
            case "itemsbytype.md":
                bool indexByName = route == "itemsbyname.md";
                if (indexByName)
                {
                    markdown.Add("description: List of Magic Items by Name");
                    markdown.Add("# Magic Items by Name");
                }
                else
                {
                    markdown.Add("description: List of Magic Items by Type");
                    markdown.Add("# Magic Items by Type");
                }
                foreach (var vmList in ParseMarkdown.CodeGenModels.Values)
                {
                    // Process all the view models
                    foreach (var vm in vmList)
                    {
                        // find the view models that are magic items
                        if (vm.FileHeaders.Count == 2)
                        {
                            string key = $"{((MagicItemViewModel)vm).Name[0]}".ToUpper();
                            if (!indexByName)
                            {
                                key = $"{((MagicItemViewModel)vm).ItemType.ToString()}".ToLower();
                            }
                            if (!dictionaryIndex.ContainsKey(key))
                            {
                                dictionaryIndex.Add(key, []);
                                dictionaryIndex[key].Add(vm);
                            }
                            else
                            {
                                dictionaryIndex[key].Add(vm);
                            }
                        }
                    }
                }

                markdown.Add(string.Empty);
                foreach (var item in dictionaryIndex.Keys.OrderBy(i => i))
                {
                    if (indexByName)
                    {
                        markdown.Add($"* [Items Beginning with {item}](#{item})");
                    }
                    else
                    {
                        markdown.Add($"* [{item}](#{item})");
                    }
                }
                markdown.Add(string.Empty);
                foreach (var item in dictionaryIndex.Keys.OrderBy(i => i))
                {
                    markdown.Add($"## [{item}](#{item})");
                    foreach (var detail in dictionaryIndex[item].OrderBy(o => o.ProperName))
                    {
                        markdown.Add($"* [{detail.ProperName}](#../magicitems/{detail.Name}.html)");
                    }
                    markdown.Add(string.Empty);
                }
                return parseModel = new ParseModel(route, markdown.ToImmutableArray());
            default:
                break;
        }

        return parseModel;
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
            fileList.Add(outputFile);
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
        // Create the initial CodeGeneration Model
        ParseModel parseModel = ConvertMarkdownToParseModel(filePath);
        Logger.LogDebug($"Converting markdown file {parseModel.Route} to ParseModel");
        ICodeGen vm = new CodeGenerationModel(parseModel);
        ParseMarkdown.ParseMarkdownToHTML(vm);

        // Convert to a specific version of the model
        if (vm.FileHeaders.Count > 0)
        {
            switch (vm.FileHeaders.Count)
            {
                // Rules files have just a description line in the header
                case 1:
                    Logger.LogDebug($"Converting markdown rules file {parseModel.Route} to ParseModel");
                    vm = new RulesViewModel(parseModel);
                    break;
                // Magic Items have two header entries.  Name and type.
                case 2:
                    Logger.LogDebug($"Converting markdown magic item file {parseModel.Route} to ParseModel");
                    vm = new MagicItemViewModel(parseModel);
                    break;
                // Monsters have three header entries.  Name, type and challenge rating.
                case 3:
                    Logger.LogDebug($"Converting markdown monster file {parseModel.Route} to ParseModel");
                    vm = new MonsterViewModel(parseModel);
                    break;
                // spells have four header entries.  Name, school, level and character classes that can cast the spell.
                case 4:
                    Logger.LogDebug($"Converting markdown spell file {parseModel.Route} to ParseModel");
                    vm = new SpellViewModel(parseModel);
                    break;
            }
        }

        // Get the route for the code generation model
        var dirName = vm.ParseModel.Route?.Substring(0, vm.ParseModel.Route.LastIndexOf("/"));
        if (!string.IsNullOrEmpty(dirName))
        {
            if (!ParseMarkdown.CodeGenModels.ContainsKey(dirName))
            {
                ParseMarkdown.CodeGenModels.Add(dirName, []);
            }
            ParseMarkdown.CodeGenModels[dirName].Add(vm);
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
