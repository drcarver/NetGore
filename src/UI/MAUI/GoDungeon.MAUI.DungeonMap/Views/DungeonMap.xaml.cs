using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Views;

public partial class DungeonMapView : ContentPage
{
	public DungeonMapView(IDungeonMapViewModel vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}