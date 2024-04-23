using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using D20.Character.Interfaces;
using D20.Character.Tables;
using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;
using D20.Monsters.Interfaces;

using NetGore.Interfaces;
using NetGore.UI.Admin.Views;

using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace NetGore.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    /// <summary>
    /// The list of tables in the DI
    /// </summary>
    private List<INamedTable> _tables = [];

    /// <summary>
    /// The name of the table
    /// </summary>
    [ObservableProperty]
    string name;

    /// <summary>
    /// The description of the table
    /// </summary>
    [ObservableProperty]
    string description;

    /// <summary>
    /// The Navigation Table list
    /// </summary>
    [ObservableProperty]
    List<GameNavigationTableEntry> items = [];

    /// <summary>
    /// The currently selected row
    /// </summary>
    [ObservableProperty]
    IGameNavigationTableEntry? selectedItem;

    /// <summary>
    /// The TapCommand for when a row is tapped
    /// </summary>
    [RelayCommand]
    async Task Tap()
    {
        if (SelectedItem != null)
        {
            await Shell.Current.GoToAsync(SelectedItem.Route);
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="navigationTable">The navigation table</param>
    public MainPageViewModel(IMainNavigationTable navigationTable, 
        IServiceProvider services)
    {
        navigationTable.InitializeTable();
        Name = navigationTable.ProperName ?? navigationTable.Name;
        Description = navigationTable.Description ?? navigationTable.Name;
        Items = navigationTable.Table.Cast<GameNavigationTableEntry>().ToList();

        IHumanoidRaceTable? raceTable = services.GetService<IHumanoidRaceTable>();
        if (raceTable == null)
        {
            raceTable = new HumanoidRaceTable();
        }

        IHumanoidRaceFactory? raceFactory = services.GetService<IHumanoidRaceFactory>();
        var halfling = raceFactory?.Create(RaceEnum.Halfling);
        var randomRace = raceFactory?.CreateRandom();
        var gametables = services.GetServices<IRandomTable>().ToList(); 
    }
}
