using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.CodeGenerator.Interfaces;
using GoDungeon.CodeGenerator.Models;
using GoDungeon.Core.Enum;

namespace GoDungeon.CodeGenerator.ViewModels;

public partial class MagicItemViewModel : CodeGenerationModel, IMagicItem
{
    /// <summary>
    /// The type of magic item
    /// </summary>
    [ObservableProperty]
    private MagicItemTypeEnum itemType;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="parseModel">The magic item's parse model</param>
    public MagicItemViewModel(ParseModel parseModel)
        : base(parseModel)
    {
        ParseModel = parseModel;
        var itemTypeString = FileHeaders[1].Replace("type: ", string.Empty);
        System.Enum.TryParse<MagicItemTypeEnum>(itemTypeString, true, out itemType);
    }
}
