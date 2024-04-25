using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Core.ViewModels
{
    /// <summary>
    /// The base table entry. This only contains the name.  it
    /// is the most common entry table need. A table entry usually 
    /// uses a enumerated type as a name (or key).  The table entries
    /// can be accessed by name or their number in the list.
    /// </summary>
    public class GameTableEntryViewModel : ObservableValidator, IGameTableEntry
    {
    }
}