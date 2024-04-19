using D20.Core.Interfaces;

namespace D20.Gaming.Interfaces;

public interface IGemStoneEntry : IGameTableEntry
{
    /// <summary>
    /// The vale of the stone in gold pieces
    /// </summary>
    int Value { get; set; }

    /// <summary>
    /// The list of gem stones at this value
    /// </summary>
    List<string>? GemStones { get; set; }
}