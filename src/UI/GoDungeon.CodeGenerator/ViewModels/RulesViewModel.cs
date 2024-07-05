using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.CodeGenerator.Models;

public partial class RulesViewModel : NamedTableEntryViewModel
{
    [ObservableProperty]
    private string? description;

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
        description = parseModel.FileHeaders[0].Replace(" from the 5th Edition (5e) SRD (System Reference Document).", string.Empty);
        Name = Utilities.CleanupForCSharp(fileInfo.Name.Replace(fileInfo.Extension, string.Empty));
    }
}
