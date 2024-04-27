using D20.Gaming.Enum;
using D20.Gaming.Interfaces;

namespace D20.Gaming.Models;

public class GemStoneEntry : IGemStoneEntry
{
    /// <summary>
    /// The type of treasure
    /// </summary>
    public TreasureTypeEnum TreasureType { get; set; }

    /// <summary>
    /// The value of the stone in gold pieces
    /// </summary>
    public int Value { get; set; }

    /// <summary>
    /// The list of gem stones at this value
    /// </summary>
    public List<string>? GemStones { get; set; }
}