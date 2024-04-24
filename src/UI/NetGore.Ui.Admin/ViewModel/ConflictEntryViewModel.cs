using CommunityToolkit.Mvvm.ComponentModel;

using D20.Background.Interfaces;
using D20.Character.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class ConflictEntryViewModel : ObservableObject
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
    /// The conflict points of the entry
    /// </summary>
    [ObservableProperty]
    int conflictPoints;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="model">The model to be loaded</param>
    public ConflictEntryViewModel(IConflictTableEntry model)
    {
        Description = model.Description;
        ProperName = model.ProperName ?? model.Name;
        ConflictPoints = model.ConflictPoints;
    }
}