using System;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    /// <summary>
    /// The base Game table entry. This is all some
    /// tables need.  A table entry usually uses a 
    /// enumerated type as a name (or key) and a
    /// range to access the entries by number or 
    /// randomly
    /// </summary>
    public partial class RandomTableEntryViewModel : StandardTableEntryViewModel, IRandomTableEntry
    {
        /// <summary>
        /// The range of the entry
        /// </summary>
        [ObservableProperty]
        private Range range;
    }
}