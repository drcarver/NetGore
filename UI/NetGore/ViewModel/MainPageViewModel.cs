using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using NetGore.Core.Interfaces;

namespace NetGore.ViewModel;

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    ObservableCollection<string> items = [];

    [ObservableProperty]
    string text = string.Empty;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrEmpty(Text))
            return;
        Items.Add(Text);

        Text = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (Items.Contains(s))
        {
            Items.Remove(s);
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    public MainViewModel(IServiceProvider services)
    {
        var itemList = services.GetServices<IGameTable>();
        foreach (var item in itemList)
        {
            Items.Add(item.Name);
        }
    }
}
