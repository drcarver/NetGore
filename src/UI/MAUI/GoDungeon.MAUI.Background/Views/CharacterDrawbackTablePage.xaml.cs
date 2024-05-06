using GoDungeon.Background.Tables;

namespace GoDungeon.MAUI.Background.Views;

public partial class CharacterDrawbackTablePage : ContentPage
{
    public CharacterDrawbackTablePage(CharacterDrawbackTable vm)
    {
        InitializeComponent();

        BindingContext = vm;
        vm.InitializeTable();
    }
}