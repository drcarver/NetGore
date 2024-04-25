using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.MAUI.Core.ViewModels;

public partial class MAUICoreTableViewModel : BaseObjectViewModel, IQueryAttributable
{
    /// <summary>
    /// The selected row
    /// </summary>
    [ObservableProperty]
    private IGameTableEntry? selectedItem;

    /// <summary>
    /// The proper name of the table
    /// </summary>
    [ObservableProperty]
    private string? properName;

    /// <summary>
    /// The table itself
    /// </summary>
    [ObservableProperty]
    private ObservableCollection<IGameTableEntry>? table;

    /// <summary>
    /// The name of the Table
    /// </summary>
    [ObservableProperty]
    public string? name;

    /// <summary>
    /// The description of the table
    /// </summary>
    [ObservableProperty]
    private string? description;

    /// <summary>
    /// The service provider from the DI container
    /// </summary>
    private IServiceProvider Services { get; }

    /// <summary>
    /// Constructor
    /// </summary>
    public MAUICoreTableViewModel(IServiceProvider services)
    {
        Services = services;
    }

    /// <summary>
    /// Can you get to a detail view with a tap gesture?
    /// </summary>
    [RelayCommand]
    private async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }

    /// <summary>
    /// Query attributes for Navigation
    /// </summary>
    /// <param name="query">The navigation query</param>
    public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var table = (IGameTable)query[nameof(GameTable)];
        Name = nameof(MAUICoreTableViewModel);
        Description = "Core tables for the game";
        ProperName = "Core Tables";

        // Get the core tables in order
        Table = [];
        Table.Add(new GameNavigationEntryViewModel(Services?.GetService<IAbilityModifierTable>()));
        Table.Add(new GameNavigationEntryViewModel(Services?.GetService<IAcrobaticsModifiersTable>()));
        Table.Add(new GameNavigationEntryViewModel(Services?.GetService<IAlignmentTable>()));
        Table.Add(new GameNavigationEntryViewModel(Services?.GetService<IGenderTable>()));
        Table.Add(new GameNavigationEntryViewModel(Services?.GetService<ILanguageTable>()));
        Table.Add(new GameNavigationEntryViewModel(Services?.GetService<IRandomAlignmentTable>()));
        Table.Add(new GameNavigationEntryViewModel(Services?.GetService<ISpellAbilityModifierTable>()));
    }
}
