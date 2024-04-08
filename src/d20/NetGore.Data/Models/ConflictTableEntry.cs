using System.Diagnostics.CodeAnalysis;
using NetGore.Data.Interfaces;

namespace NetGore.Data.Models;

public class ConflictTableEntry : GameTableEntry, IConflictTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ConflictTableEntry()
    {
    }

    /// <summary>
    /// Conflict points
    /// </summary>
    public int ConflictPoints { get; set; }
}
