using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.CodeGenerator.Models;

public partial class RulesViewModel : StandardTableEntryViewModel, IRules
{
    /// <summary>
    /// The ParseModel for this rule file
    /// </summary>
    public ParseModel ParseModel { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parseModel">The parse model for the file</param>
    public RulesViewModel(ParseModel parseModel) 
    {
        ParseModel = parseModel;
        var fileInfo = new FileInfo(ParseModel?.Route);
        Description = parseModel.FileHeaders[0].Replace(" from the 5th Edition (5e) SRD (System Reference Document).", string.Empty).Replace("description:", string.Empty).Trim();
        Name = Utilities.CleanupForCSharp(fileInfo.Name.Replace(fileInfo.Extension, string.Empty));
        foreach (var line in ParseModel.Markdown)
        {
            if (line.StartsWith("# "))
            {
                ProperName = line.Replace("# ", string.Empty);
                break;
            }
        }
    }
}
