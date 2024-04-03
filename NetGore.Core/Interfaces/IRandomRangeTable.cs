namespace NetGore.Core.Interfaces;

/// <summary>
/// The random range table
/// </summary>
public interface IRandomRangeTable
{
    /// <summary>
    /// The sides to the dice for the table
    /// </summary>
    int DiceSides { get; set; }

    /// <summary>
    /// The total for the dice
    /// </summary>
    int Total { get; set; }

    /// <summary>
    /// The actual table
    /// </summary>
    List<IRandomTableRangeEntry>? Table { get; set; }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    IRandomTableRangeEntry? GetRandomEntry();

    /// <summary>
    /// Get a entry from the table based on it's name
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    IRandomTableRangeEntry? GetEntryByName(string name);

    /// <summary>
    /// Get a entry from the table based on it's number
    /// in a range
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    IRandomTableRangeEntry? GetEntryByNumber(int number);
}