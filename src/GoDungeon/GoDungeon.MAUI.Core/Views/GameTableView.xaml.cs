using GoDungeon.MAUI.Core.ViewModels;

namespace GoDungeon.MAUI.Core.Views;

public partial class GameTableView : ContentPage
{
	public GameTableView(MAUICoreTableViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm; 
	}
}