using System.IO;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateModel : IGenerateModel
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="loggerFactory">The logger factory</param>
    public GenerateModel(ILoggerFactory loggerFactory)
    {
        logger = loggerFactory.CreateLogger<GenerateModel>();
    }

    /// <summary>
    /// The logger for this model
    /// </summary>
    private readonly ILogger<GenerateModel> logger;

    /// <summary>
    /// The list of models and tables for the name space
    /// </summary>
    public List<UseGoDungeonModel> GoDungeonModelList { get; } = [];

    /// <summary>
    /// Generate the constructor for the main view model
    /// </summary>
    /// <param name="outputDir">The output directory</param>
    /// <param name="model">The mark down table model</param>
    /// <param name="filePath">The path to the markdown file</param>
    /// <param name="filePath">The contents of the markdown file</param>
    public void GenerateConstructor(string outputDir, IMarkDownTableModel model, string filePath, List<string> markDown)
    {
        var fileInfo = new FileInfo(filePath);
        var nameSpace = Utilities.CleanupForCSharp(fileInfo.DirectoryName.Split('\\').LastOrDefault());
        if (nameSpace == null || model == null)
        {
            return;
        }

        // Create the output directory and get the base file name
        nameSpace = char.ToUpper(nameSpace[0]) + nameSpace.Substring(1);
        outputDir = $"{outputDir}\\MAUI\\";
        Directory.CreateDirectory($"{outputDir}{nameSpace}\\ViewModels");
        var baseFileName = Utilities.CleanupForCSharp(fileInfo.Name.Replace(fileInfo.Extension, string.Empty));

        // Get the base file name
        var fileName = char.ToUpper(baseFileName[0]) + baseFileName.Substring(1);
        using (var stream = File.CreateText($"{outputDir}\\{nameSpace}\\ViewModels\\{fileName}ViewModel.cs"))
        {
            GenerateViewModel(stream, fileName, model, nameSpace, markDown);
        }

        // Get the base file name
        Directory.CreateDirectory($"{outputDir}{nameSpace}\\Interfaces");
        using (var stream = File.CreateText($"{outputDir}\\{nameSpace}\\Interfaces\\I{fileName}.cs"))
        {
            GenerateViewModelInterface(stream, fileName, nameSpace);
        }

        // Copy off the file information for later
        var goDungeonFileName = $"{outputDir}\\{nameSpace}\\UseGoDungeon{nameSpace}Generated.cs";
        var item = GoDungeonModelList.FirstOrDefault(m => m.FileName == goDungeonFileName);
        if (item == null)
        {
            item = new UseGoDungeonModel
            {
                OutputDirectory = outputDir,
                NameSpace = nameSpace,
                FileName = goDungeonFileName,
                DIObjects = new List<string>()
            };
            GoDungeonModelList.Add(item);
        }

        // build up the list of items to add to the DI
        var fname = $"{baseFileName}ViewModel";
        fname = Char.ToUpper(fname[0]) + fname.Substring(1);
        var tableName = Utilities.CleanupForCSharp(fname);
        if (! item.DIObjects.Contains(tableName))
        {
            item.DIObjects.Add(tableName);
        }
        foreach (var table in model.TableCaption)
        {
            tableName = Utilities.CleanupForCSharp($"{table}Table");
            if (! item.DIObjects.Contains(tableName))
            {
                item.DIObjects.Add(tableName);
            }
        }
    }

    /// <summary>
    /// Generate the view model constructor as a partial class
    /// </summary>
    /// <param name="stream">The output stream</param>
    /// <param name="fileInfo">The output file info</param>
    /// <param name="model">The markdown table model</param>
    /// <param name="nameSpace">The namespace for the file</param>
    /// <param name="nameSpace">The markDown file contents</param>
    private void GenerateViewModel(TextWriter stream, string fileName, IMarkDownTableModel model, string nameSpace, List<string> markDown)
    {
        stream.WriteLine("//");
        stream.WriteLine($"// {fileName}");
        stream.WriteLine("//");
        stream.WriteLine("using System;");
        stream.WriteLine();
        stream.WriteLine($"using GoDungeon.Core.ViewModels;");
        stream.WriteLine();
        stream.WriteLine($"using GoDungeon.{nameSpace}.Interfaces;");
        stream.WriteLine();
        stream.WriteLine($"using Microsoft.Extensions.Logging;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.{nameSpace}.ViewModels;");
        stream.WriteLine();
        stream.WriteLine("/// <Summary>");
        stream.WriteLine($"/// View Model for {fileName}View");
        stream.WriteLine("/// </Summary>");
        stream.WriteLine($"public partial class {fileName}ViewModel  : BaseObjectViewModel, I{fileName}");
        stream.WriteLine("{");
        stream.WriteLine("\t#region Constructor Parameters");
        string paramName;
        foreach (var item in model.TableCaption)
        {
            paramName = $"{Utilities.CleanupForCSharp(item)}";
            stream.WriteLine("\t/// <Summary>");
            stream.WriteLine($"\t/// {item}");
            stream.WriteLine("\t/// </Summary>");
            stream.WriteLine($"\tprivate I{paramName}Table {paramName}Table {{ get; }}");
            stream.WriteLine();
        }
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\t/// Logger");
        stream.WriteLine("\t/// </Summary>");
        stream.WriteLine($"\tILogger Logger {{ get; }}");
        stream.WriteLine();
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\t/// The service provider");
        stream.WriteLine("\t/// </Summary>");
        stream.WriteLine($"\tIServiceProvider Services {{ get; }}");
        stream.WriteLine();
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\t/// The formatted text for the view model body");
        stream.WriteLine("\t/// </Summary>");
        stream.WriteLine("\t[ObservableProperty]");
        stream.WriteLine($"\tFormattedString formattedBodyText;");
        stream.WriteLine();
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\t/// Initialize the view model");
        stream.WriteLine("\t/// </Summary>");
        stream.WriteLine($"\tpartial void Initialize();");
        stream.WriteLine("\t#endregion");
        stream.WriteLine();
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine("\t/// Constructor");
        stream.WriteLine("\t/// </Summary>");
        foreach (var item in model.TableCaption)
        {
            paramName = $"{Utilities.CleanupForCSharp(char.ToLower(item[0]) + item.Substring(1))}";
            stream.WriteLine($"\t/// <param name=\"{paramName}Table\">{item}</param>");
        }
        stream.WriteLine("\t/// <param name=\"loggerFactory\">The logger factory</param>");
        stream.WriteLine("\t/// <param name=\"services\">The service provider</param>");
        stream.WriteLine($"\tpublic {fileName}ViewModel");
        stream.WriteLine($"\t(");
        foreach (var item in model.TableCaption)
        {
            paramName = $"I{Utilities.CleanupForCSharp(item)}Table";
            var paramValue = $"{Utilities.CleanupForCSharp(char.ToLower(item[0]) + item.Substring(1))}Table";
            stream.WriteLine($"\t\t{paramName} {paramValue},");
        }
        stream.WriteLine($"\t\tIServiceProvider services,");
        stream.WriteLine($"\t\tILoggerFactory loggerFactory");
        stream.WriteLine($"\t)");
        stream.WriteLine("\t{");
        stream.WriteLine("\t\t#region Save off the constructor parameters");
        foreach (var item in model.TableCaption)
        {
            paramName = $"{Utilities.CleanupForCSharp(item)}Table";
            var paramValue = $"{Utilities.CleanupForCSharp(char.ToLower(item[0]) + item.Substring(1))}Table";
            stream.WriteLine($"\t\t// {item}");
            stream.WriteLine($"\t\t{paramName} = {paramValue};");
            stream.WriteLine($"\t\t{paramName}.InitializeTable();");
            stream.WriteLine();
        }

        paramName = $"{Utilities.CleanupForCSharp(fileName)}Table";
        stream.WriteLine($"\t\t// The service provider from the DI");
        stream.WriteLine($"\t\tServices = services;");
        stream.WriteLine();
        stream.WriteLine($"\t\t// The Logger from the DI factory");
        stream.WriteLine($"\t\tLogger = loggerFactory.CreateLogger(nameof({fileName.Replace("Constructor", string.Empty)}ViewModel));");
        stream.WriteLine();
        stream.WriteLine($"\t\t// Initialize the view model");
        stream.WriteLine($"\t\tInitialize();");
        stream.WriteLine("\t\t#endregion");
        stream.WriteLine();
        stream.WriteLine("\t\t// Generate the body text from the markdown");
        stream.WriteLine($"\t\tformattedBodyText = new FormattedString();");
        stream.WriteLine("\t\tBodyText();");
        stream.WriteLine("\t}");
        GenerateViewModelBody(stream, model, markDown);
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the view model body for a View from the markDown
    /// </summary>
    /// <param name="stream">The view model stream</param>
    /// <param name="model"></param>
    /// <param name="markDown"></param>
    private void GenerateViewModelBody(TextWriter stream, IMarkDownTableModel model, List<string> markDown)
    {
        // Did we add the description
        bool addDescription = false;

        stream.WriteLine();
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine("\t/// The formatted text for the body of the view model");
        stream.WriteLine("\t/// </Summary>");
        stream.WriteLine("\tprivate void BodyText()");
        stream.WriteLine("\t{");
        foreach (var line in markDown)
        {
            if (string.IsNullOrEmpty(line.Trim()))
            {
                continue;
            }
            var txt = line.Trim().Replace("\"", "\\\"");
            if (line.Trim().StartsWith("description: "))
            {
                txt = txt
                    .Replace(" from the 5th Edition (5e) SRD (System Reference Document)", String.Empty)
                    .Replace("description: ", string.Empty);
                addDescription = true;
                stream.WriteLine($"\t\tPageDescription.Spans.Add(new span {{ Text = \"{txt}\\n\\n\" Font=\"10\", FontAttribute=\"Italic\" }});");
                continue;
            }
            else
            {
                stream.WriteLine($"\t\tFormattedBodyText.Spans.Add(new span {{ Text = \"{txt}\\n\\n\" }});");
            }
        }
        stream.WriteLine("\t}");

        // Add the various properties
        AddDescriptionProperty(stream, addDescription);
    }

    /// <summary>
    /// The output stream
    /// </summary>
    /// <param name="stream">The text stream</param>
    /// <param name="adddescription">do we add add a description</param>
    private void AddDescriptionProperty(TextWriter stream, bool addDescription)
    {
        if (addDescription)
        {
            stream.WriteLine();
            stream.WriteLine("\t/// <Summary>");
            stream.WriteLine($"\t/// The formatted text for the view model body");
            stream.WriteLine("\t/// </Summary>");
            stream.WriteLine("\t[ObservableProperty]");
            stream.WriteLine($"\tFormattedString pageDescription = new FormattedString();");
        }
    }

    /// <summary>
    /// Generate the view model constructor as a partial class
    /// </summary>
    /// <param name="stream">The output stream</param>
    /// <param name="fileName">The output file name</param>
    /// <param name="nameSpace">The namespace fir the file</param>
    private void GenerateViewModelInterface(TextWriter stream, string fileName, string nameSpace)
    {
        stream.WriteLine("//");
        stream.WriteLine($"// {fileName}");
        stream.WriteLine("//");
        stream.WriteLine("using System;");
        stream.WriteLine();
        stream.WriteLine($"using GoDungeon.Core.Interfaces;");
        stream.WriteLine();
        stream.WriteLine($"using Microsoft.Extensions.Logging;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.{nameSpace}.Interfaces;");
        stream.WriteLine();
        stream.WriteLine($"public interface I{fileName}  : IBaseObject");
        stream.WriteLine("{");
        stream.WriteLine("}");
    }

    /// <summary>
    /// Generate the Service Collection extension for the namespace
    /// </summary>
    /// <param name="stream">The output stream</param>
    /// <param name="model">The GoDungeon model file</param>
    public void GenerateServicesCollectionExtension(TextWriter stream, UseGoDungeonModel model)
    {
        stream.WriteLine("//");
        stream.WriteLine($"// {model.FileName}");
        stream.WriteLine("//");
        stream.WriteLine($"using GoDungeon.{model.NameSpace}.Interfaces;");
        stream.WriteLine($"using GoDungeon.{model.NameSpace}.Tables;");
        stream.WriteLine($"using GoDungeon.{model.NameSpace}.ViewModels;");
        stream.WriteLine();
        stream.WriteLine($"using Microsoft.Extensions.DependencyInjection;");
        stream.WriteLine($"using Microsoft.Extensions.Logging;");
        stream.WriteLine();
        stream.WriteLine($"namespace GoDungeon.{model.NameSpace};");
        stream.WriteLine();
        stream.WriteLine($"public static class DataService");
        stream.WriteLine("{");
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\t/// DI tables and view models");
        stream.WriteLine("\t/// </Summary>");
        stream.WriteLine($"\tpublic static IServiceCollection UseGoDungeon{model.NameSpace}Generated(this IServiceCollection collection)");
        stream.WriteLine("\t{");
        stream.WriteLine("\t\t// Add tables to the service collection");
        stream.WriteLine("\t\tcollection");
        string paramName;
        stream.WriteLine("\t\t\t// Tables");
        foreach (var item in model.DIObjects.Where(o => o.EndsWith("Table")).OrderBy(o => o))
        {
            paramName = $"{Utilities.CleanupForCSharp(item)}";
            stream.WriteLine($"\t\t\t.AddSingleton<I{paramName}, {paramName}>()");
        }
        stream.WriteLine();
        stream.WriteLine("\t\t\t// ViewModels");
        foreach (var item in model.DIObjects.Where(o => o.EndsWith("ViewModel")).OrderBy(o => o))
        {
            paramName = $"{Utilities.CleanupForCSharp(item)}";
            stream.WriteLine($"\t\t\t.AddTransient<I{paramName.Replace("ViewModel", string.Empty)}, {paramName}>()");
        }
        stream.WriteLine("\t\t\t// Routes");
        foreach (var item in model.DIObjects.Where(o => o.EndsWith("ViewModel")).OrderBy(o => o))
        {
            paramName = $"{Utilities.CleanupForCSharp(item)}";
            stream.WriteLine($"\t\t\t.AddTransientWithShellRoute<{paramName.Replace("ViewModel", "View")}, {paramName}>({paramName.Replace("ViewModel", "View")})");
        }
        stream.WriteLine("\t\t;");
        stream.WriteLine();
        stream.WriteLine("\t\treturn collection;");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }
}
