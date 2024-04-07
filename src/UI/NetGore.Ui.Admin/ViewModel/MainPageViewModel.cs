using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using NetGore.Core.Interfaces;
using NetGore.Data.Models;

namespace NetGore.UI.Admin.ViewModel;

public partial class MainViewModel : ObservableObject
{
    /// <summary>
    /// The list of Types with the same base type from
    /// a given assembly
    /// </summary>
    /// <typeparam name="TBaseType">The base type</typeparam>
    /// <returns>The type list</returns>
    private Type[] FindSubClassesOf<TBaseType>()
    {
        var baseType = typeof(TBaseType);
        var assembly = baseType.Assembly;

        return assembly.GetTypes().Where(t => t.IsSubclassOf(baseType)).ToArray();
    }

    /// <summary>
    /// The list of game tables from the DI
    /// </summary>
    private List<IGameTable> gameTables = [];

    /// <summary>
    /// The GameTable view model list
    /// </summary>
    [ObservableProperty]
    ObservableCollection<GameTableGridViewModel> items = [];

    /// <summary>
    /// The currently selected row
    /// </summary>
    [ObservableProperty]
    GameTableGridViewModel? selectedItem;

    /// <summary>
    /// The TapCommand for when a row is tapped
    /// </summary>
    [RelayCommand]
    void Tap()
    {
        if (SelectedItem != null)
        {
            // Navigate to detail
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public MainViewModel(IServiceProvider services)
    {
        foreach (var item in FindSubClassesOf<GameTable>())
        {
            var gt = (IGameTable?)services.GetService(item);
            if (gt != null)
            {
                gameTables.Add(gt);
                Items.Add(new GameTableGridViewModel(gt));
            }
        }
    }
}
