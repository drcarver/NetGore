using NetGore.UI.Admin.ViewModel;

namespace NetGore.UI.Admin.Views;

public partial class CharacterAdvancementDetailPage : ContentPage
{
	public CharacterAdvancementDetailPage(CharacterAdvancementDetailViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}