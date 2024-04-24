using CommunityToolkit.Mvvm.ComponentModel;

using D20.Core.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class GameTableEntryViewModel : ObservableObject
{
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
    public GameTableEntryViewModel(IStandardTableEntry model)
    {
        Description = model.Description;
        ProperName = model.ProperName ?? model.Name;
    }
}