using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IRandomTable
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
    List<RandomTableEntry>? Table { get; set; }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    RandomTableEntry? GetRandomEntry();

    /// <summary>
    /// Get a entry from the table based on it's name
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    RandomTableEntry? GetEntryByName(string name);

    /// <summary>
    /// Get a entry from the table based on it's number
    /// in a range
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    RandomTableEntry? GetEntryByNumber(int number);
}
