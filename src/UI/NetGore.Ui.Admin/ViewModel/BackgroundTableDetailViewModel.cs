using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using D20.Background.Models;
using D20.Character.Models;
using D20.Core.Interfaces;
using D20.Core.Tables;

namespace NetGore.UI.Admin.ViewModel;

public partial class BackgroundTableDetailViewModel : ObservableObject, IQueryAttributable
{
    /// <summary>
    /// The dice to roll for a random entry 
    /// </summary>
    [ObservableProperty]
    string? dice;

    /// <summary>
    /// The description of the table
    /// </summary>
    [ObservableProperty]
    string? description;

    /// <summary>
    /// The entries in the table
    /// </summary>
    [ObservableProperty]
    ObservableCollection<BackgroundEntryViewModel> table = [];

    /// <summary>
    /// One level entry
    /// </summary>
    [ObservableProperty]
    BackgroundEntryViewModel? selectedItem;

    /// <summary>
    /// The title of the table
    /// </summary>
    [ObservableProperty]
    string properName;

    /// <summary>
    /// Navigate back a level
    /// </summary>
    /// <returns>A task for the navigation</returns>
    [RelayCommand]
    async Task Goback()
    {
        await Shell.Current.GoToAsync("..");
    }

    /// <summary>
    /// Query attributes for Navigation
    /// </summary>
    /// <param name="query">The navigation query</param>
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var table = (IRandomTable) query[nameof(NamedTable)];
        if (table == null)
            return;

        Dice = $"d{table.DiceSides}";
        Description = table.Description;
        ProperName = table.ProperName ?? table.Name;

        foreach (BackgroundTableEntry entry in table.Table)
        {
            Table.Add(new BackgroundEntryViewModel(entry));
        }
    }
}
