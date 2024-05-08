using GoDungeon.MAUI.Core.Tables;

namespace GoDungeon.MAUI.Core.Views;

public partial class CoreMenuTablePage : ContentPage
{
    public CoreMenuTablePage(CoreMenuTable vm)
    {
        InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}