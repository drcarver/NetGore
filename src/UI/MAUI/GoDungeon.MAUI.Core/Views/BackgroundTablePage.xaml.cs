using GoDungeon.Core.Interfaces;

namespace GoDungeon.MAUI.Core.Views;

public partial class BackgroundTablePage : ContentPage, IQueryAttributable
{
    public BackgroundTablePage()
    {
        InitializeComponent();
    }

    /// <summary>
    /// Get the BindingContext from the query parameter
    /// </summary>
    /// <param name="query"></param>
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        var vm = (IRandomTable)query["DetailPage"];
        vm.InitializeTable();
        BindingContext = vm;
    }
}