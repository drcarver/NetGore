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
                ProperName = line.Replace("# ", string.Empty).Trim();
                Name = Utilities.CleanupForCSharp(ProperName)?.Trim();
                break;
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

        var descString = FileHeaders.FirstOrDefault(s => s.StartsWith("description:"));
        if (descString != null)
        {
            Description = descString.Replace(" from the 5th Edition (5e) SRD (System Reference Document).", string.Empty);
            Description = Description.Replace("description:", string.Empty).Trim();

        }

    }
}
