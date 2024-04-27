using D20.Core.Interfaces;
using D20.Gaming.Enum;

namespace D20.Gaming.Interfaces;

public interface IJewelryEntry : IGameTableEntry
{
    /// <summary>
    /// The type of treasure
    /// </summary>
    TreasureTypeEnum TreasureType { get; set; }

    /// <summary>
    /// The value of the stone in gold pieces
    /// </summary>
    int Value { get; set; }

    /// <summary>
    /// The list of jewelry at this value
    /// </summary>
    List<string> Jewelry { get; set; }
}