using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using D20.Core.Interfaces;
using D20.Core.Models;

namespace NetGore.UI.Admin.ViewModel;

public partial class GameTableAdminViewModel : ObservableObject, IQueryAttributable
{
    /// <summary>
    /// The ProperName of the table
    /// </summary>
    [ObservableProperty]
    string? name;

    /// <summary>
    /// The description of the table
    /// </summary>
    [ObservableProperty]
    string? description;

    /// <summary>
    /// The entries in the table
    /// </summary>
    [ObservableProperty]
    ObservableCollection<GameTableEntryViewModel> items = [];

    [ObservableProperty]
    GameTableEntryViewModel? selectedItem;

    /// <summary>
    /// The TapCommand for when a row is tapped
    /// </summary>
    [RelayCommand]
    async Task Tap()
    {
        if (SelectedItem != null)
        {
            //await Shell.Current.GoToAsync(SelectedItem.Route);
        }
    }

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

        Name = table.ProperName ?? table.Name;
        Description = table.Description;

        foreach (var entry in table.Table)
        {
            items.Add(new GameTableEntryViewModel(entry));
        }
    }
}
