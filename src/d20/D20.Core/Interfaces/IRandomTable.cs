namespace D20.Core.Interfaces;

public interface IRandomTable : INamedTable
{
    /// <summary>
    /// The dice to roll
    /// </summary>
    int DiceSides { get; set; }

    /// <summary>
    /// Get a random entry by range using the dice
    /// sides to determine the type of dice to roll
    /// </summary>
    /// <returns>The entry in the given range</returns>
    IRandomTableEntry GetRandomRangeEntry();

    /// <summary>
    /// Get a entry where the number is in the entries
    /// range
    /// </summary>
    /// <param name="number">A number in the possible range</param>
    /// <returns>The entry with the range that includes the number</returns>
    IRandomTableEntry GetRangeEntryByNumber(int number);
}