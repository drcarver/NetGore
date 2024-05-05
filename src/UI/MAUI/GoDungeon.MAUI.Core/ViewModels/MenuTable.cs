using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

using GoDungeon.Core.Interfaces;
using GoDungeon.Core.Tables;
using GoDungeon.MAUI.Core.Interfaces;

namespace GoDungeon.MAUI.Core.ViewModels;

public partial class MenuTable : GameTable, IMenuTable
{
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
        return SelectedItem != null && (Table != null || Table.Count == 0);
    }

    /// <summary>
    /// Fired when the selection changes
    /// </summary>
    protected override async Task SelectionChanged()
    {
        if (SelectedItem != null)
        {
            await Shell.Current.GoToAsync(((GameNavigationEntryViewModel)SelectedItem).Route);
        }
    }
}
