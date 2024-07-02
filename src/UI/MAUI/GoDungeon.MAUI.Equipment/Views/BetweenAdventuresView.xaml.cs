using GoDungeon.MAUI.Equipment.Interfaces;

namespace GoDungeon.MAUI.Equipment.Views;

public partial class BetweenAdventuresView : ContentPage
{
    public BetweenAdventuresView(IBetweenAdventuresViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}