using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Views;

public partial class DungeonMap : ContentPage
{
	public DungeonMap(IDungeonMapViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}