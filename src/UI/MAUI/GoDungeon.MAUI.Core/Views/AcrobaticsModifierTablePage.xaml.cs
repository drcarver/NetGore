using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.Core.ViewModels;

namespace GoDungeon.MAUI.Core.Views;

public partial class AcrobaticsModifierTablePage : ContentPage
{
	public AcrobaticsModifierTablePage(AcrobaticsModifierTable vm)
	{
		InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}