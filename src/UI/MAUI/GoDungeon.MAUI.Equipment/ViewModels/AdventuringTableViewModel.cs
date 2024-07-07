using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.MAUI.Equipment.Interfaces;
using GoDungeon.MAUI.Equipment.Views;

namespace GoDungeon.MAUI.Equipment.ViewModels;

public partial class AdventuringTableViewModel : ObservableObject, IAdventuringTableViewModel
{
    [RelayCommand]
    private async Task BetweenAdventures()
    {
        await Shell.Current.GoToAsync(nameof(BetweenAdventuresView));
    }

    [RelayCommand]
    private async Task Movement()
    {
        await Shell.Current.GoToAsync(nameof(MovementView));
    }

    [ObservableProperty]
    private string title = "Adventuring Menu";

    public AdventuringTableViewModel()
    {
    }
}