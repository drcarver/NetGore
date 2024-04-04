using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Data.Models;

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
    /// The range for this entry.  Used to get random 
    /// entries or entries by number.
    /// </summary>
    public Range Range { get; set; }

    /// <summary>
    /// The English name for the entry
    /// </summary>
    public string? ProperName { get; set; }
}