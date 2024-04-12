using System.Diagnostics.CodeAnalysis;
using System.Security.Cryptography;

using D20.Core.Interfaces;

namespace D20.Core.Models;

public class RandomTable : GameTable, IRandomTable
{
    /// <summary>
    /// The random table is used for those tables
    /// where a entry is selected based on a roll
    /// of the dice.  Each entry has a range of dice
    /// values (e.g. 1..5 on a 20 sided dice).
    /// </summary>
    [SetsRequiredMembers]
    public RandomTable()
    {
    }

    /// <summary>
    /// The sides to a dice to be rolled to get random
    /// entries from the table
    /// </summary>
    public int DiceSides { get; set; }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected TableEntry.</returns>
    public IRandomTableEntry GetRandomRangeEntry()
    {
        using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
        {
            return GetRangeEntryByNumber(RandomNumberGenerator.GetInt32(DiceSides) + 1);
        }
    }

    /// <summary>
    /// Get a entry from the table by it's number within
    /// a range
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public IRandomTableEntry GetRangeEntryByNumber(int number)
    {
        var te = Table.Cast<IRandomTableEntry>()
            .First(t =>
                t.Range.Start.Value <= number
                    && t.Range.End.Value >= number);
        return te;
    }
}
