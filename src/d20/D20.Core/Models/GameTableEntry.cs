using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;
using D20.Core.Interfaces;

namespace D20.Core.Models;

/// <summary>
/// The base Game table entry. This is all some
/// tables need.  A table entry usually uses a 
/// enumerated type as a name (or key) and a
/// range to access the entries by number or 
/// randomly
/// </summary>
public class GameTableEntry : BaseObject, IGameTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public GameTableEntry()
    {
    }

    /// <summary>
    /// The English name for the entry
    /// </summary>
    public string? ProperName { get; set; }
}