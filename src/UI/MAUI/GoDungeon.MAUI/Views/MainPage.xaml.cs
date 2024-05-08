using GoDungeon.MAUI.Core.Interfaces;
using GoDungeon.MAUI.Interfaces;

namespace GoDungeon.MAUI.Views;

public partial class MainPage : ContentPage
{
    public MainPage(IMainMenuTable vm)
    {
        InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}