using GoDungeon.Core.Tables;

namespace GoDungeon.MAUI.Core.Views;

public partial class LanguageTablePage : ContentPage
{
	public LanguageTablePage(LanguageTable vm)
	{
		InitializeComponent();

		BindingContext = vm;
		vm.InitializeTable();
	}
}