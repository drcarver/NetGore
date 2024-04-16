using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using D20.Core.Interfaces;
using D20.Core.Models;

namespace NetGore.UI.Admin.ViewModel;

public partial class GameTableDetailViewModel : ObservableObject, IQueryAttributable
{
    /// <summary>
    /// The ProperName of the table
    /// </summary>
    [ObservableProperty]
    string? properName;

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
    ObservableCollection<GameTableEntryViewModel> table = [];

    [ObservableProperty]
    GameTableEntryViewModel? selectedItem;

    [RelayCommand]
    async Task Goback()
    {
        await Shell.Current.GoToAsync("..");
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var table = (IGameTable) query[nameof(D20.Core.Models.GameTable)];
        if (table == null)
            return;

        ProperName = table.ProperName ?? table.Name;
        Description = table.Description;

        foreach (var entry in table.Table)
        {
            if (entry is IStandardTableEntry)
            {
                Table.Add(new GameTableEntryViewModel((IStandardTableEntry) entry));
            }
        }
    }
}
