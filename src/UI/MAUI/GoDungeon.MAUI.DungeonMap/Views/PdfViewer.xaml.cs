using GoDungeon.MAUI.DungeonMap.Interfaces;

namespace GoDungeon.MAUI.DungeonMap.Views;

public partial class PdfViewer : ContentPage
{
	public PdfViewer(IPdfViewer vm)
	{
		InitializeComponent();

		BindingContext = vm;
	}
}