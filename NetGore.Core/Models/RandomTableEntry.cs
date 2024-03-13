using Microsoft.EntityFrameworkCore;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class RandomTableEntry : BaseObject, IRandomTableEntry
{
    /// <summary>
    /// The lower range of the dice roll for the table entry
    /// </summary>
    [Comment("The Lower range of the dice roll.")]
    public int LowerRange { get; set; }

    /// <summary>
    /// The upper range of the dice roll for the table entry
    /// </summary>
    [Comment("The Upper range of the dice roll.")]
    public int UpperRange { get; set; }

    /// <summary>
    /// The alternate table entry for this row
    /// </summary>
    public RandomTable? AlternateTable { get; set; }
}
