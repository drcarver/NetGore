using GoDungeon.MAUI.Equipment.Interfaces;

namespace GoDungeon.MAUI.Equipment.Views;

public partial class AdventuringTableView : ContentPage
{
    public AdventuringTableView(IAdventuringTableViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}