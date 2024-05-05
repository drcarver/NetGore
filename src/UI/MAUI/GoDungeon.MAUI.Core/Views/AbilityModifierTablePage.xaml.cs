using GoDungeon.Core.Interfaces;

namespace GoDungeon.MAUI.Core.Views;

public partial class AbilityModifierTablePage : ContentPage
{
	public AbilityModifierTablePage(IAbilityModifierTable vm)
	{
		InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}