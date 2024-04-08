using NetGore.UI.Admin.ViewModel;

namespace NetGore.UI.Admin.Views;

public partial class GameTableDetailPage : ContentPage
{
	public GameTableDetailPage(GameTableDetailViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}