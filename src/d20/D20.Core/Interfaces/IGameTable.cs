using D20.Core.Enum;

namespace D20.Core.Interfaces;

/// <summary>
/// The interface for the table
/// </summary>
public interface IGameTable : IBaseObject
{
    /// <summary>
    /// The proper name of the table
    /// </summary>
    string? ProperName { get; set; }

    /// <summary>
    /// The type of table
    /// </summary>
    TableTypeEnum TableType { get; set; }

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
    /// Initialize the game table.  This is a seperate method so we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of optimiation to conserve memeory on big tables
    /// </summary>
    virtual void InitializeTable()
    {
    }
}