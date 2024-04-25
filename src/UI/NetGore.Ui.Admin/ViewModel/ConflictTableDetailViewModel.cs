using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using D20.Background.Interfaces;
using D20.Background.Models;
using D20.Core.Tables;

namespace NetGore.UI.Admin.ViewModel;

public partial class ConflictTableDetailViewModel : ObservableObject, IQueryAttributable
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
    ObservableCollection<ConflictEntryViewModel> table = [];

    [ObservableProperty]
    ConflictEntryViewModel? selectedItem;

    [RelayCommand]
    async Task Goback()
    {
        await Shell.Current.GoToAsync("..");
    }

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var table = (IConflictTable) query[nameof(NamedTable)];
        if (table == null)
            return;

        ProperName = table.ProperName ?? table.Name;
        Description = table.Description;

        foreach (ConflictTableEntry entry in table.Table)
        {
            Table.Add(new ConflictEntryViewModel(entry));
        }
    }
}
