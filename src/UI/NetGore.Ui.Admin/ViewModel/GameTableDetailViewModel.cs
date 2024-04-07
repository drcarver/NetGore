using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Core.Interfaces;
using NetGore.Data.Models;

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

    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var table = (IGameTable) query[nameof(GameTable)];
        if (table == null)
            return;

        ProperName = table.ProperName ?? table.Name;
        Dice = $"d{table.DiceSides}";
        Description = table.Description;

        foreach (var entry in table.Table)
        {
            Table.Add(new GameTableEntryViewModel(entry));
        }
    }
}
