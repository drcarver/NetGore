using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    /// <summary>
    /// The standard table entry. This is all most
    /// tables need.  A table entry usually uses a 
    /// enumerated type as a name (or key) and a
    /// range to access the entries by number or 
    /// randomly
    /// </summary>
    public partial class StandardTableEntryViewModel : NamedTableEntryViewModel, IStandardTableEntry
    {
        /// <summary>
        /// The English name for the entry
        /// </summary>
        [ObservableProperty]
        private string? properName;
    }
}