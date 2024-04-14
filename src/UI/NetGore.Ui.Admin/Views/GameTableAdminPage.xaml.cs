using NetGore.UI.Admin.ViewModel;

namespace NetGore.UI.Admin.Views;

public partial class GameTableAdminPage : ContentPage
{
    public GameTableAdminPage(GameTableAdminViewModel vm)
    {
        InitializeComponent();

        BindingContext = vm;
    }
}