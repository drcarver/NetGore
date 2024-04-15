using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

using D20.Core.Base;
using D20.Core.Enum;
using D20.Core.Interfaces;

namespace D20.Core.Models;

/// <summary>
/// A table of items.  This is usually a list of
/// objects each with a particular range (e.g. 01-20).
/// The table provides methods to get to items in it
/// by name, number or randomly.
/// </summary>
public class GameTable : BaseObject, IGameTable
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public GameTable()
    {
    }

    /// <summary>
    /// The proper name of the table
    /// </summary>
    public string? ProperName { get; set; } = string.Empty;

    /// <summary>
    /// The table type
    /// </summary>
    public TableTypeEnum TableType { get; set; }

    /// <summary>
    /// The table itself
    /// </summary>
    public List<IGameTableEntry> Table { get; set; } = [];

    /// <summary>
    /// Get a entry from the table by it's name
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public IGameTableEntry GetEntryByName(string Name)
    {
        var te = Table.First(t => t.Name == Name);
        return te;
    }

    /// <summary>
    /// Get a random entry from the table 
    /// </summary>
    /// <returns>The selected TableEntry.</returns>
    public IGameTableEntry GetRandomEntry()
    {
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            return Table[RandomNumberGenerator.GetInt32(Table.Count)];
        }
    }

    /// <summary>
    /// Initialize the game table.  This is a seperate method so we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of optimiation to conserve memeory on big tables
    /// </summary>
    public virtual void InitializeTable()
    {
    }
}
