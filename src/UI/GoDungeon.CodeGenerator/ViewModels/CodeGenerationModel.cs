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
    }
}
