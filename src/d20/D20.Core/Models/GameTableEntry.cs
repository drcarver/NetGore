using D20.Core.Interfaces;

namespace D20.Core.Models
{
    /// <summary>
    /// The base table entry. This only contains the name.  it
    /// is the most common entry table need. A table entry usually 
    /// uses a enumerated type as a name (or key).  The table entries
    /// can be accessed by name or their number in the list.
    /// </summary>
    public class GameTableEntry : IGameTableEntry
    {
    }
}