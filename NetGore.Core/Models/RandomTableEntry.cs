using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class RandomTableEntry : BaseObject, IRandomTableEntry
{
    /// <summary>
    /// The lower range of the dice roll for the table entry
    /// </summary>
    [Description("The Lower range of the dice roll.")]
    public int LowerRange { get; set; }

    /// <summary>
    /// The upper range of the dice roll for the table entry
    /// </summary>
    [Description("The Upper range of the dice roll.")]
    public int UpperRange { get; set; }

    /// <summary>
    /// The alternate table entry for this row
    /// </summary>
    [Description("The table to chain too")]
    public RandomTable? AlternateTable { get; set; }

    /// <summary>
    /// Consructor
    /// </summary>
    [SetsRequiredMembers]
    public RandomTableEntry()
    {
    }
}
