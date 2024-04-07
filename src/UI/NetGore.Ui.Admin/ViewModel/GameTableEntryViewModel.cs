using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Core.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class GameTableEntryViewModel : ObservableObject
{
    /// <summary>
    /// The range of the entries on the dice (0-9) for example
    /// </summary>
    [ObservableProperty]
    Range range;

    /// <summary>
    /// The description of the entry
    /// </summary>
    [ObservableProperty]
    string? description;

    /// <summary>
    /// The proper name of the entry
    /// </summary>
    [ObservableProperty]
    string? properName;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="model">The model to be loaded</param>
    public GameTableEntryViewModel(IGameTableEntry model)
    {
        Range = model.Range;
        Description = model.Description;
        ProperName = model.ProperName ?? model.Name;
    }
}