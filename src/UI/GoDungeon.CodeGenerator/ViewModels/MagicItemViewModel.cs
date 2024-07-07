using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.CodeGenerator.CodeGen;
using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.CodeGenerator.ViewModels;

public partial class MagicItemViewModel : StandardTableEntryViewModel, IMagicItem
{
    /// <summary>
    /// The type of magic item
    /// </summary>
    [ObservableProperty]
    private MagicItemTypeEnum itemType;

    /// <summary>
    /// The parse model for this magic item
    /// </summary>
    public ParseModel ParseModel { get; }

    public MagicItemViewModel(ParseModel parseModel)
    {
        ParseModel = parseModel;
        ProperName = parseModel.FileHeaders[0].Replace("name: ", string.Empty);
        Name = Utilities.CleanupForCSharp(ProperName);
        var itemTypeString = parseModel.FileHeaders[1].Replace("type: ", string.Empty);
        Enum.TryParse<MagicItemTypeEnum>(itemTypeString, true, out itemType);
    }
}
