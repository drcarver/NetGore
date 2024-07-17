using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.ViewModels;

namespace GoDungeon.CodeGenerator.Models;

public partial class RulesViewModel : CodeGenerationModel, IRules
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parseModel">The parse model for the file</param>
    public RulesViewModel(ParseModel parseModel) 
        : base(parseModel)
    {
        ParseModel = parseModel;
        parseModel.FileHeaders[0] = parseModel.FileHeaders[0].Replace(" from the 5th Edition (5e) SRD (System Reference Document).", string.Empty).Trim();
        Description = parseModel.FileHeaders[0];
    }
}
