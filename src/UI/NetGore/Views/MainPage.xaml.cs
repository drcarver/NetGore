using NetGore.ViewModel;

namespace NetGore.Views;

public partial class MainPage : ContentPage
{
    public MainPage(IMainPageViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}