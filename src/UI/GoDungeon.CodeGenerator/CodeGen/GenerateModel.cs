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
    public void GenerateConstructor(string outputDir, IMarkDownTableModel model, string filePath)
    {
        var fileInfo = new FileInfo(filePath);
        var nameSpace = Utilities.CleanupForCSharp(fileInfo.DirectoryName.Split('\\').LastOrDefault());
        if (nameSpace == null || model == null)
        {
            return;
        }

        // Create the output directory and get the base file name
        nameSpace = char.ToUpper(nameSpace[0]) + nameSpace.Substring(1);
        Directory.CreateDirectory($"{outputDir}\\{nameSpace}\\ViewModels");
        var baseFileName = Utilities.CleanupForCSharp(fileInfo.Name.Replace(fileInfo.Extension, string.Empty));

        // Get the base file name
        var fileName = char.ToUpper(baseFileName[0]) + baseFileName.Substring(1);
        using (var stream = File.CreateText($"{outputDir}\\{nameSpace}\\ViewModels\\{fileName}ViewModel.cs"))
        {
            GenerateViewModel(stream, fileName, model, nameSpace);
        }

        // Get the base file name
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
    /// <param name="model">The markdown file</param>
    /// <param name="nameSpace">The namespace fir the file</param>
    private void GenerateViewModel(TextWriter stream, string fileName, IMarkDownTableModel model, string nameSpace)
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
        stream.WriteLine($"public partial class {fileName}ViewModel  : BaseObjectViewModel, I{fileName}");
        stream.WriteLine("{");
        stream.WriteLine("\t#region Constructor Parameters");
        string paramName;
        foreach (var item in model.TableCaption)
        {
            paramName = $"{Utilities.CleanupForCSharp(item)}";
            stream.WriteLine("\t/// <Summary>");
            stream.WriteLine($"\t/// {item}");
            stream.WriteLine("\t/// <Summary>");
            stream.WriteLine($"\tprivate I{paramName}Table {paramName}Table {{ get; }}");
            stream.WriteLine();
        }
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\t/// Logger");
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\tILogger Logger {{ get; }}");
        stream.WriteLine();
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\t/// The service provider");
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\tIServiceProvider Services {{ get; }}");
        stream.WriteLine();
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\t/// Initialize the view model");
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine($"\tpartial void Initialize();");
        stream.WriteLine("\t#endregion");
        stream.WriteLine();
        stream.WriteLine("\t/// <Summary>");
        stream.WriteLine("\t/// Constructor");
        stream.WriteLine("\t/// <Summary>");
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
        stream.WriteLine("\t}");
        stream.WriteLine("}");
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
        stream.WriteLine("\t/// <Summary>");
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
        stream.WriteLine("\t\t\t// View Models");
        foreach (var item in model.DIObjects.Where(o => o.EndsWith("ViewModel")).OrderBy(o => o))
        {
            paramName = $"{Utilities.CleanupForCSharp(item)}";
            stream.WriteLine($"\t\t\t.AddTransient<I{paramName.Replace("ViewModel", string.Empty)}, {paramName}>()");
        }
        stream.WriteLine("\t\t;");
        stream.WriteLine();
        stream.WriteLine("\t\treturn collection;");
        stream.WriteLine("\t}");
        stream.WriteLine("}");
    }
}
