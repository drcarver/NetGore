using NetGore.UI.Admin.ViewModel;

namespace NetGore.UI.Admin.Views;

public partial class ConflictTableDetailPage : ContentPage
{
	public ConflictTableDetailPage(ConflictTableDetailViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}