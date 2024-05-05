using GoDungeon.Core.Tables;

namespace GoDungeon.MAUI.Core.Views;

public partial class SpellAbilityModifierTablePage : ContentPage
{
	public SpellAbilityModifierTablePage(SpellAbilityModifierTable vm)
	{
		InitializeComponent();

		BindingContext = vm;
		vm.InitializeTable();
	}
}