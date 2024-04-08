using NetGore.UI.Admin.ViewModel;

namespace NetGore.UI.Admin.Views;

public partial class BackgroundTableDetailPage : ContentPage
{
	public BackgroundTableDetailPage(BackgroundTableDetailViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}