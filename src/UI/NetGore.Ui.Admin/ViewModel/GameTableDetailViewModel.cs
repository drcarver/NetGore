using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using NetGore.Core.Interfaces;

namespace NetGore.UI.Admin.ViewModel;

public partial class GameTableDetailViewModel : ObservableObject
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

    /// <summary>
    /// Constructor
    /// </summary>
    public GameTableDetailViewModel(IGameTable gameTable)
    {
        ProperName = gameTable.ProperName ?? gameTable.Name;
        Dice = $"d{gameTable.DiceSides}";
        Description = gameTable.Description;

        foreach (var entry in gameTable.Table)
        {
            Table.Add(new GameTableEntryViewModel(entry));
        }
    }
}
