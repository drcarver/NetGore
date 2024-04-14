using NetGore.UI.Admin.ViewModel;

namespace NetGore.UI.Admin.Views;

public partial class GameTableDetailPage : ContentPage
{
	public GameTableDetailPage(GameTableAdminViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}