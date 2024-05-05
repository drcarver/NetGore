using GoDungeon.Core.Interfaces;

namespace GoDungeon.MAUI.Core.Views;

public partial class AlignmentTablePage : ContentPage
{
	public AlignmentTablePage(IAlignmentTable vm)
	{
		InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}