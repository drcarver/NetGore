using System.Diagnostics.CodeAnalysis;

using D20.Core.Interfaces;

namespace D20.Core.Models;

/// <summary>
/// The base Game table entry. This is all some
/// tables need.  A table entry usually uses a 
/// enumerated type as a name (or key) and a
/// range to access the entries by number or 
/// randomly
/// </summary>
public class RandomTableEntry : StandardTableEntry, IRandomTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public RandomTableEntry()
    {
    }

    /// <summary>
    /// The range of the entry
    /// </summary>
    public Range Range { get; set; }
}