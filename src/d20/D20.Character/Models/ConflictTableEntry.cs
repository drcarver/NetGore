using System.Diagnostics.CodeAnalysis;

using D20.Character.Interfaces;
using D20.Core.Models;

namespace D20.Character.Models;

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
