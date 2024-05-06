using GoDungeon.Core.Tables;

namespace GoDungeon.MAUI.Core.Views;

public partial class SkillsTablePage : ContentPage
{
	public SkillsTablePage(SkillTable vm)
	{
		InitializeComponent();

		BindingContext = vm;
		vm.InitializeTable();
	}
}