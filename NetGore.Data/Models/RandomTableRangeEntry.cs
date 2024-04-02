using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Data.Interfaces;

namespace NetGore.Core.Models;

public class RandomTableRangeEntry : BaseObject, IRandomTableRangeEntry
{
    /// <summary>
    /// The lower range of the dice roll
    /// </summary>
    public Range Range { get; set; }

    /// <summary>
    /// The alternate table entry for this row
    /// </summary>
    public string? AlternateTable { get; set; }

    /// <summary>
    /// The racial traits for this creature 
    /// </summary>
    public List<TraitEnum> Traits { get; set; } = [];

    /// <summary>
    /// The proper name of the entry.  Not the variable
    /// name but the English version with spaces and 
    /// hyphens
    /// </summary>
    public string? ProperName { get; set; }

    /// <summary>
    /// Allow a filter of entries by class
    /// </summary>
    public ClassEnum Class { get; set; } = ClassEnum.Any;

    /// <summary>
    /// Conflict points
    /// </summary>
    public int ConflictPoints { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public RandomTableRangeEntry()
    {
    }
}
