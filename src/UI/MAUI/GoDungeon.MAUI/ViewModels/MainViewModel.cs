using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.MAUI.Equipment.Views;
using GoDungeon.MAUI.Interfaces;

namespace GoDungeon.MAUI.ViewModels;

public partial class MainViewModel : ObservableObject, IMainViewModel
{
    [RelayCommand]
    private async Task Adventuring()
    {
        await Shell.Current.GoToAsync(nameof(AdventuringTableView));
    }

    [ObservableProperty]
    private string title = "Main Menu";

    public MainViewModel()
    {
    }
}