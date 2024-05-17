using GoDungeon.MAUI.DungeonMap.Interfaces;
using GoDungeon.MAUI.DungeonMap.ViewModels;

namespace GoDungeon.MAUI.DungeonMap.Views;

public partial class DungeonMapPage : ContentPage
{
	public DungeonMapPage(DungeonMapViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}