using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Character.Models;

public class DeityTableEntry : StandardTableEntry, IDeityTableEntry
{
    /// <summary>
    /// The deity alignment
    /// </summary>
    public AlignmentEnum Alignment { get; set; }

    /// <summary>
    /// The deity symbol(s)
    /// </summary>
    public string? Symbol { get; set; }

    /// <summary>
    /// The suggested classes for this deity
    /// </summary>
    public List<ClassEnum> SuggestedClasses { get; set; } = [];

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public DeityTableEntry()
    {
    }
}
