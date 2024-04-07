using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using NetGore.Core.Interfaces;
using NetGore.Data.Models;
using NetGore.UI.Admin.Views;

namespace NetGore.ViewModel;

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
    ObservableCollection<GameTableViewModel> items = [];

    /// <summary>
    /// The currently selected row
    /// </summary>
    [ObservableProperty]
    GameTableViewModel? selectedItem;

    /// <summary>
    /// The TapCommand for when a row is tapped
    /// </summary>
    [RelayCommand]
    async void Tap()
    {
        if (SelectedItem != null)
        {
            var table = gameTables.First(gt => gt.Id.Equals(SelectedItem.Id));
            var navigationParameter = new Dictionary<string, object>
            {
                { nameof(GameTable), table }
            };
            await Shell.Current.GoToAsync(nameof(GameTableDetailPage), navigationParameter);
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
                Items.Add(new GameTableViewModel(gt));
            }
        }
    }
}
