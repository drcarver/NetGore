using GoDungeon.MAUI.Equipment.Interfaces;

namespace GoDungeon.MAUI.Equipment.Views;

public partial class MovementView : ContentPage
{
    public MovementView(IMovementViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
        vm.Initialize();
    }
}