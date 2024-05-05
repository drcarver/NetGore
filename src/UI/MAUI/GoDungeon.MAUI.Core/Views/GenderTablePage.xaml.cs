using GoDungeon.Core.Interfaces;

namespace GoDungeon.MAUI.Core.Views;

public partial class GenderTablePage : ContentPage
{
    public GenderTablePage(IGenderTable vm)
    {
        InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}