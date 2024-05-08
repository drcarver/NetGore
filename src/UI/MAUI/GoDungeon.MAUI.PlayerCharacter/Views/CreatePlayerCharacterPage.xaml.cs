using GoDungeon.MAUI.PlayerCharacter.ViewModels;

namespace GoDungeon.MAUI.PlayerCharacter.Views;

public partial class CreatePlayerCharacterPage : ContentPage
{
	public CreatePlayerCharacterPage(PlayerCharacterViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}