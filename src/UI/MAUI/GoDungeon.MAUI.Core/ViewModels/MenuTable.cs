using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.MAUI.Core.Interfaces;

namespace GoDungeon.MAUI.Core.ViewModels;

public partial class MenuTable : GameTable, IMenuTable
{
    public IServiceProvider Services { get; }

    /// <summary>
    /// The query parameter as a dictionary 
    /// </summary>
    /// <param name="query">The query attribute</param>
    public void ApplyQueryAttributes(IDictionary<string, object> query)
    {
        if (query.Count > 0)
        {
            SelectedItem = (GameNavigationEntryViewModel)query[nameof(GameNavigationEntryViewModel)];
        }
    }

    /// <summary>
    /// Can the selection change
    /// </summary>
    /// <returns>True if the selection can change</returns>
    protected override bool CanChangeSelection()
    {
        return SelectedItem != null && Table != null && Table.Count != 0;
    }

    /// <summary>
    /// Fired when the selection changes
    /// </summary>
    protected override async Task SelectionChanged()
    {
        if (SelectedItem != null)
        {
            IDictionary<string, object> query = new Dictionary<string, object>();
            var gameMenuItem = (GameNavigationEntryViewModel)SelectedItem;
            if (gameMenuItem != null)
            {
                if (gameMenuItem.PageDetailType != null)
                {
                    var detailPageType = Services.GetService(gameMenuItem.PageDetailType);
                    query.Add("DetailPage", detailPageType);
                    await Shell.Current.GoToAsync(gameMenuItem.Route, query);
                }
                else
                {
                    await Shell.Current.GoToAsync(((GameNavigationEntryViewModel)SelectedItem).Route);
                }
            }
        }
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="services">The service provider.  We need this for navigation</param>
    public MenuTable(IServiceProvider services)
    {
        Services = services;
    }
}
