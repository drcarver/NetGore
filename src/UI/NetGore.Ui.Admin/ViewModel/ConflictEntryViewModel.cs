using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Data.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class ConflictEntryViewModel : ObservableObject
{
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
        Range = model.Range;
        Description = model.Description;
        ProperName = model.ProperName ?? model.Name;
        ConflictPoints = model.ConflictPoints;
    }
}