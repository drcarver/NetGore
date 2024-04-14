using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using D20.Core.Enum;
using D20.Core.Interfaces;
using D20.Core.Models;

using NetGore.Interfaces;
using NetGore.UI.Admin.Views;

using System.Collections.ObjectModel;

namespace NetGore.ViewModel;

public partial class MainPageViewModel : ObservableObject
{
    /// <summary>
    /// The list of Types with the same base type from
    /// a given assembly
    /// </summary>
    /// <typeparam name="GameTable">The base type</typeparam>
    /// <returns>The type list</returns>
    private Type[] FindSubClassesOf<GameTable>()
    {
        var baseType = typeof(GameTable);
        var assembly = baseType.Assembly;

        return assembly.GetTypes().Where(t => t.IsSubclassOf(baseType)).ToArray();
    }

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
            //await Shell.Current.GoToAsync(SelectedItem.Route);
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="navigationTable">The navigation table</param>
    public MainPageViewModel(IMainNavigationTable navigationTable)
    {
        Name = navigationTable.ProperName ?? navigationTable.Name;
        Description = navigationTable.Description ?? navigationTable.Name;
        Items = navigationTable.Table.Cast<GameNavigationTableEntry>().ToList();
    }
}
