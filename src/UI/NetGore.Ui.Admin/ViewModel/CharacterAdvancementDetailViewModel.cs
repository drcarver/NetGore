using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using D20.Character.Interfaces;
using D20.Character.Models;
using D20.Core.Tables;

namespace NetGore.UI.Admin.ViewModel;

public partial class CharacterAdvancementDetailViewModel : ObservableObject, IQueryAttributable
{
    /// <summary>
    /// The description of the table
    /// </summary>
    [ObservableProperty]
    string? description;

    /// <summary>
    /// The entries in the table
    /// </summary>
    [ObservableProperty]
    ObservableCollection<CharacterAdvancementEntryViewModel> table = [];

    /// <summary>
    /// One level entry
    /// </summary>
    [ObservableProperty]
    CharacterAdvancementEntryViewModel? selectedItem;

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
        var table = (ICharacterAdvancementTable) query[nameof(NamedTable)];
        if (table == null)
            return;

        Description = table.Description;
        ProperName = table.ProperName ?? table.Name;

        foreach (CharacterAdvancementEntry entry in table.Table)
        {
            Table.Add(new CharacterAdvancementEntryViewModel(entry));
        }
    }
}
