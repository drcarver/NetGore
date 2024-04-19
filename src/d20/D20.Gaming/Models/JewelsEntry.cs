using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Gaming.Enum;
using D20.Gaming.Interfaces;

namespace D20.Gaming.Models;

public class JewelsEntry : GameTableEntry, IJewelsEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public JewelsEntry()
    {
    }

    /// <summary>
    /// The type of treasure
    /// </summary>
    public TreasureTypeEnum TreasureType { get; set; }

    /// <summary>
    /// The value of the jewel in gold pieces
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// The list of jewels at this value
    /// </summary>
    public List<string>? Jewels { get; set; }
}