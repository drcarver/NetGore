using CommunityToolkit.Maui.Converters;
using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Data.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class BackgroundEntryViewModel : ObservableObject
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
    /// The proper name of the table
    /// </summary>
    [ObservableProperty]
    string properName;

    /// <summary>
    /// The character traits for this background
    /// </summary>
    [ObservableProperty]
    string? traits;

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="model">The model to be loaded</param>
    public BackgroundEntryViewModel(IBackgroundTableEntry model)
    {
        Range = model.Range;
        Description = model.Description;
        ProperName = model.ProperName ?? model.Name;

        for (int i = 0; i < model.Traits.Count; i++)
        {
            if (i != model.Traits.Count - 1)
            {
                Traits += model.Traits[i] + ", ";
            }
            else
            {
                Traits += model.Traits[i];
            }
        }
    }
}
