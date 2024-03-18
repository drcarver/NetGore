using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IRandomTableEntry
{
    /// <summary>
    /// The lower range of the dice roll for the table entry
    /// </summary>
    int LowerRange { get; set; }

    /// <summary>
    /// The upper range of the dice roll for the table entry
    /// </summary>
    int UpperRange { get; set; }

    /// <summary>
    /// The alternate table entry for this row
    /// </summary>
    RandomTable? AlternateTable { get; set; }
}
