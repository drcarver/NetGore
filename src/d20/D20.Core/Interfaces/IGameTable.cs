using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Core.Interfaces;

public interface IGameTable : IBaseObject
{
    /// <summary>
    /// The proper name of the table
    /// </summary>
    string? ProperName { get; set; }

    /// <summary>
    /// The table type
    /// </summary>
    TableTypeEnum TableType { get; set; }

    /// <summary>
    /// The table itself
    /// </summary>
    List<IGameTableEntry> Table { get; set; }

    /// <summary>
    /// Initialize the game table.  This is a separate method so 
    /// we can create a game table for it's meta properties
    /// with out creating the actual able values.  A bit of 
    /// initialize to conserve memory on big tables
    /// </summary>
    virtual void InitializeTable()
    {
    }

}