using GoDungeon.MAUI.Interfaces;
using GoDungeon.MAUI.ViewModels;

namespace GoDungeon.MAUI.Views;

public partial class MainPage : ContentPage
{
    public MainPage(IMainMenu vm)
    {
        InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}