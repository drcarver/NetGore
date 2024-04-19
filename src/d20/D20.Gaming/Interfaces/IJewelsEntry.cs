using D20.Core.Interfaces;
using D20.Gaming.Enum;

namespace D20.Gaming.Interfaces;

internal interface IJewelsEntry : IGameTableEntry
{
    /// <summary>
    /// The type of treasure
    /// </summary>
    TreasureTypeEnum TreasureType { get; set; }

    /// <summary>
    /// The value of the jewel in gold pieces
    /// </summary>
    int Value { get; set; }

    /// <summary>
    /// The list of jewels at this value
    /// </summary>
    List<string>? Jewels { get; set; }
}