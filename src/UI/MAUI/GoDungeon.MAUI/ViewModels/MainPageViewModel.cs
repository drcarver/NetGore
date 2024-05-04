using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.Interfaces;
using GoDungeon.Monsters.Interfaces;
using GoDungeon.Monsters.Tables;

namespace GoDungeon.MAUI.ViewModels;

public partial class MainPageViewModel : ObservableObject
{
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
    public MainPageViewModel(
        IMainMenu navigationTable, 
        IServiceProvider services)
    {
        navigationTable.InitializeTable();
        Name = navigationTable.ProperName ?? navigationTable.Name;
        Description = navigationTable.Description ?? navigationTable.Name;

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
