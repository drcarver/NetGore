namespace NetGore.Core.Interfaces;

/// <summary>
/// The interface for the table
/// </summary>
public interface IGameTable : IBaseObject
{
    /// <summary>
    /// The dice used to access the entries in the
    /// table
    /// </summary>
    int DiceSides { get; set; }

    /// <summary>
    /// The table it self
    /// </summary>
    List<IGameTableEntry> Table { get; set; }

    /// <summary>
    /// Return the table entry by name
    /// </summary>
    /// <param name="Name">The name of the entry</param>
    /// <returns>The table entry</returns>
    IGameTableEntry GetEntryByName(string Name);

    /// <summary>
    /// Return the table entry by number
    /// </summary>
    /// <param name="number">The number of entry</param>
    /// <returns>The table entry</returns>
    IGameTableEntry GetEntryByNumber(int number);

    /// <summary>
    /// Get a random entry from the table
    /// </summary>
    /// <returns>The table entry</returns>
    IGameTableEntry GetRandomEntry();
}