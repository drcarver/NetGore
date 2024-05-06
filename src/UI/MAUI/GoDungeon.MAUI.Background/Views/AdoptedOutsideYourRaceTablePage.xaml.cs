using GoDungeon.Background.Interfaces;
using GoDungeon.Background.Tables;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;

namespace GoDungeon.MAUI.Background.Views;

public partial class AdoptedOutsideYourRaceTablePage : ContentPage
{
    public AdoptedOutsideYourRaceTablePage(AdoptedOutsideYourRaceTable vm)
    {
        InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}