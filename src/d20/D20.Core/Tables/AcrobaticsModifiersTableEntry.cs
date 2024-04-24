using System.Diagnostics.CodeAnalysis;

using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Core.Tables;

public class AcrobaticsModifiersTableEntry : StandardTableEntry, IAcrobaticsModifiersTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public AcrobaticsModifiersTableEntry()
    {
    }

    /// <summary>
    /// The difficulty check modifier
    /// </summary>
    public int DifficultyCheckModifier { get; internal set; }
}