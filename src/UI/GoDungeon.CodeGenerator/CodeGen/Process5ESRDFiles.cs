using System;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

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
    /// <param name="fileList">The input dir for the indexes</param>
    private void GenerateIndexFiles(List<string> fileList)
    {
        var indexes = fileList
            .Where(i => (i.Contains("GamemasterRules") || i.Contains("spellcasting"))
                && i.EndsWith("index.md")).ToArray();
        for (int i = 0; i < indexes.Length; i++)
        {
            string fRoute = indexes[i].Replace("_", string.Empty);
            GenerateNameIndexes(fRoute);
        }
    }

    /// <summary>
    /// Generate the name index parse and code generation models
    /// </summary>
    /// <param name="route">route to the index</param>
    private void GenerateNameIndexes(string route)
    {
        List<ICodeGen> list = [];
        List<string> markdown = [];
        string fRoute = route;
        bool byName = true;

        // Get the set the index type
        for (int b = 0; b < 2; b++)
        {
            if (b == 1)
            {
                byName = false;
            }
            for (int i = 2; i < 5; i++)
            {
                markdown.Clear();
                switch (i)
                {
                    case 2:
                        if (byName)
                        {
                            fRoute = route.Replace("\\index.md", "/itemsbyname.md");
                            markdown.Add("# Magic Items by Name");
                        }
                        else
                        {
                            fRoute = route.Replace("\\index.md", "/itemsbytype.md");
                            markdown.Add("# Magic Items by Type");
                        }
                        GetIndexByName(markdown, 2, byName);
                        break;
                    case 3:
                        // the second gamemasterrules route
                        if (byName)
                        {
                            fRoute = route.Replace("\\index.md", "/monstersbyname.md");
                            markdown.Add("# Monsters by Name");
                        }
                        else
                        {
                            fRoute = route.Replace("\\index.md", "/monstersbytype.md");
                            markdown.Add("# Monsters by Race");
                        }
                        GetIndexByName(markdown, 3, byName);
                        break;
                    case 4:
                        if (byName)
                        {
                            markdown.Add("# Spells by Name");
                            fRoute = route.Replace("\\index.md", "/spellsbyname.md");
                        }
                        else
                        {
                            fRoute = route.Replace("\\index.md", "/spellsbylevel.md");
                            markdown.Add("# Spells by level");
                        }
                        GetIndexByName(markdown, 4, byName);
                        break;
                }
                ICodeGen cgm = new CodeGenerationModel(new ParseModel(fRoute, markdown));
                ParseMarkdown.ParseMarkdownToHTML(cgm);
                list.Add(cgm);
            }
            ParseMarkdown.CodeGenModels.Add(fRoute, list);
        }
    }

    /// <summary>
    /// Generate the index file by name
    /// </summary>
    /// <param name="markdown">The markdown list</param>
    /// <param name="fieldCount">The number of fields to break out the Code Generation file</param>
    /// <returns></returns>
    private void GetIndexByName(List<string> markdown, int fieldCount, bool byName)
    {
        Dictionary<string, List<ICodeGen>> fieldDictionary = [];

        // Process all the view models
        foreach (var vmList in ParseMarkdown.CodeGenModels.Values)
        {
            foreach (var codeGenModel in vmList.Where(f => f.FileHeaders.Count == fieldCount).ToList())
            {
                string key = codeGenModel.Name.ToUpper()[0].ToString();
                if (!byName)
                {
                    switch (fieldCount)
                    {
                        case 2:
                            key = ((MagicItemViewModel)codeGenModel).ItemType.ToString();
                            break;
                        case 3:
                            var vm = (MonsterViewModel)codeGenModel;
                            if (vm.RaceSubType == Core.Enum.RaceSubTypeEnum.Any)
                            {
                                key = $"{vm.RaceType.ToString()}";
                            }
                            else
                            {
                                key = $"{vm.RaceType.ToString()} ({vm.RaceSubType.ToString()})";
                            }
                            break;
                        case 4:
                            key = ((SpellViewModel)codeGenModel).Level.ToString();
                            break;
                    }
                }

                // The field dictionary for the model
                if (!fieldDictionary.ContainsKey(key))
                {
                    fieldDictionary.Add(key, []);
                    fieldDictionary[key].Add(codeGenModel);
                }
                else
                {
                    fieldDictionary[key].Add(codeGenModel);
                }
            }
        }
        CreateIndexDetails(fieldDictionary, markdown);
    }

    /// <summary>
    /// The index details
    /// </summary>
    /// <param name="fieldDictionary">The index dictionary</param>
    /// <param name="markdown">The Markdown string</param>
    private void CreateIndexDetails(
        Dictionary<string, List<ICodeGen>> fieldDictionary,
        List<string> markdown)
    {
        // create the key list
        markdown.Add(string.Empty);
        foreach (var key in fieldDictionary.Keys.OrderBy(i => i))
        {
            markdown.Add($"* [{key}](#{Utilities.CleanupForCSharp(key)})");
        }

        // Create the detail lists
        markdown.Add(string.Empty);
        foreach (var item in fieldDictionary.Keys.OrderBy(i => i))
        {
            markdown.Add($"## {item}");
            foreach (var detail in fieldDictionary[item].OrderBy(o => o.ProperName))
            {
                if (detail.FileHeaders.Count == 2)
                {
                    markdown.Add($"* [{detail.ProperName}](magicitems/{detail.Name}.html)");
                    continue;
                }
                if (detail.FileHeaders.Count == 3)
                {
                    markdown.Add($"* [{detail.ProperName}](monsters/{detail.Name}.html)");
                    continue;
                }
                if (detail.FileHeaders.Count == 4)
                {
                    markdown.Add($"* [{detail.ProperName}](spells/{detail.Name}.html)");
                    continue;
                }
            }
            markdown.Add(string.Empty);
        }
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
        var parseModel = new ParseModel(filePath, File.ReadLines(fullPath).ToList<string>());

        // process the tables in the markdown
        Logger.LogDebug($"Parse all the tables in the markdown file at {filePath}");
        ParseMarkdown?.ParseMarkDownTable(parseModel);

        return parseModel;
    }
}
