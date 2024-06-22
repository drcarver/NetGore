using GoDungeon.CodeGenerator.Interfaces;

namespace GoDungeon.CodeGenerator.CodeGen;

public partial class GenerateModel : IGenerateModel
{
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
        if (nameSpace == null)
        {
            return;
        }

        nameSpace = char.ToUpper(nameSpace[0]) + nameSpace.Substring(1);
        var fileName = Utilities.CleanupForCSharp(fileInfo.Name.Replace(fileInfo.Extension, string.Empty));
        fileName = char.ToUpper(fileName[0]) + fileName.Substring(1) + "Constructor";
        Directory.CreateDirectory($"{outputDir}\\{nameSpace}\\ViewModels");
        if (model != null)
        {
            using (var stream = File.CreateText($"{outputDir}\\{nameSpace}\\ViewModels\\{fileName}" + ".cs"))
            {
                GenerateViewModelConstructor(stream, fileName, model, nameSpace);
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
    private void GenerateViewModelConstructor(TextWriter stream, string fileName, IMarkDownTableModel model, string nameSpace)
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
        stream.WriteLine($"public partial class {fileName.Replace("Constructor", string.Empty)}ViewModel  : CreatureViewModel, I{fileName.Replace("Constructor", string.Empty)}");
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
        stream.WriteLine($"\tpublic {fileName.Replace("Constructor", string.Empty)}ViewModel");
        stream.WriteLine($"\t(");
        foreach (var item in model.TableCaption)
        {
            paramName = $"I{Utilities.CleanupForCSharp(item)}Table";
            var paramValue = $"{Utilities.CleanupForCSharp(char.ToLower(item[0]) + item.Substring(1))}Table";
            stream.WriteLine($"\t\t{paramName} {paramValue},");
        }
        stream.WriteLine($"\t\tIServiceProvider services,");
        stream.WriteLine($"\t\tILoggerFactory loggerFactory");
        stream.WriteLine($"\t) : base(services, loggerFactory)");
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
}
