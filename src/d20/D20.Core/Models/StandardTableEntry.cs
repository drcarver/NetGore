using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;
using D20.Core.Interfaces;

namespace D20.Core.Models;

/// <summary>
/// The standard table entry. This is all most
/// tables need.  A table entry usually uses a 
/// enumerated type as a name (or key) and a
/// range to access the entries by number or 
/// randomly
/// </summary>
public class StandardTableEntry : GameTableEntry, IStandardTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public StandardTableEntry()
    {
    }

    /// <summary>
    /// The English name for the entry
    /// </summary>
    public string? ProperName { get; set; }

    /// <summary>
    /// THe description of the entry
    /// </summary>
    public string? Description { get; set; }
}