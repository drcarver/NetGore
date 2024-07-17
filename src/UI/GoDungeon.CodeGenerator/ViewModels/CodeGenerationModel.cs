using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.CodeGenerator.ViewModels;

public class CodeGenerationModel : StandardTableEntryViewModel, ICodeGen
{
    /// <summary>
    /// The code gen parse model
    /// </summary>
    public ParseModel ParseModel { get; internal set; }

    /// <summary>
    /// The file headers
    /// </summary>
    public List<string> FileHeaders { get; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parseModel">The code generation parse model.</param>
    public CodeGenerationModel(ParseModel parseModel)
    {
        ParseModel = parseModel;
        if (parseModel == null || parseModel?.Markdown.Length == 0)
        {
            return;
        }
        foreach (var line in parseModel.Markdown)
        {
            if (line.StartsWith("# "))
            {
                ProperName = line.Replace("# ", string.Empty);
                Name = Utilities.CleanupForCSharp(ProperName);
                break;
            }
        }

        // Add the description if available
        foreach (var header in FileHeaders)
        {
            if (header.StartsWith("description:"))
            {
                parseModel.MarkDownHtml.Add($"<br><em>{header.Replace("description:", string.Empty).Trim()}</em><br>");
            }
        }

        /// The file headers for the parse model
        foreach (var line in parseModel.Markdown)
        {
            if (line.Contains(":"))
            {
                FileHeaders.Add(line);
            }
            else
            {
                break;
            }
        }
    }
}
