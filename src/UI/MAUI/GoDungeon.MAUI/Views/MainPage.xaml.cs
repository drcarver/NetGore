using GoDungeon.MAUI.ViewModels;

namespace GoDungeon.MAUI.Views;

public partial class MainPage : ContentPage
{
    public MainPage(MainPageViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}