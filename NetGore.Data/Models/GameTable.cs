using System.Diagnostics.CodeAnalysis;
using NetGore.Core;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Data.Models;

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
    /// The sides to a dice to be rolled to get random
    /// entries from the table
    /// </summary>
    public int DiceSides { get; set; }

    /// <summary>
    /// The table itself
    /// </summary>
    public List<IGameTableEntry> Table { get; set; }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected TableEntry.</returns>
    public IGameTableEntry GetRandomEntry()
    {
        Dice dice = new($"1d{DiceSides}");
        return GetEntryByNumber(dice.Total);
    }

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
    /// Get a entry from the table by it's name
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public IGameTableEntry GetEntryByNumber(int number)
    {
        var te = Table.First(t =>
                        t.Range.Start.Value <= number
                     && t.Range.End.Value >= number);
        return te;
    }
}
