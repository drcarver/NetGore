using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.MAUI.Core.Interfaces;

namespace GoDungeon.MAUI.Core.ViewModels
{
    /// <summary>
    /// The base Game table entry. This is all some
    /// tables need.  A table entry usually uses a 
    /// enumerated type as a name (or key) and a
    /// range to access the entries by number or 
    /// randomly
    /// </summary>
    public partial class GameNavigationEntryViewModel : StandardTableEntryViewModel, IGameNavigationTableEntry
    {
        /// <summary>
        /// The table type
        /// </summary>
        [ObservableProperty]
        private TableTypeEnum tableType;

        /// <summary>
        /// Route for the entry
        /// </summary>
        [ObservableProperty]
        private string? route;

        /// <summary>
        /// The page detail type
        /// </summary>
        [ObservableProperty]
        private Type? pageDetailType;
    }
}