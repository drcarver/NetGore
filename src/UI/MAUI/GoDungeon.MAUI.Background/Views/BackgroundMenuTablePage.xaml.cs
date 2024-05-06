using GoDungeon.MAUI.Background.Tables;

namespace GoDungeon.MAUI.Background.Views;

public partial class BackgroundMenuTablePage : ContentPage
{
	public BackgroundMenuTablePage(BackgroundMenuTable vm)
	{
		InitializeComponent();

		BindingContext = vm;
		vm.InitializeTable();
	}
}