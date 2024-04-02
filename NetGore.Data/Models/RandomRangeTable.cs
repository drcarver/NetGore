using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Data.Interfaces;

namespace NetGore.Core.Models;

public class RandomRangeTable : BaseObject, IRandomRangeTable
{
    /// <summary>
    /// The sides to the dice for the table
    /// </summary>
    public int DiceSides { get; set; } = 100;

    /// <summary>
    /// The total for the dice
    /// </summary>
    public int Total { get; set; }

    /// <summary>
    /// The actual table
    /// </summary>
    public List<RandomTableRangeEntry>? Table { get; set; }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected RandomTableRangeEntry.</returns>
    public virtual RandomTableRangeEntry? GetRandomEntry()
    {
        Dice dice = new($"1d{DiceSides}");
        return GetEntryByNumber(dice.Total);
    }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public virtual RandomTableRangeEntry? GetRandomEntryByClass(ClassEnum filterclass)
    {
        var filtered = Table?.Where(t => t.Class == filterclass).ToArray();
        if (filtered != null && filtered.Length > 0)
        {
            Dice dice = new($"1d{filtered.Length}");
            return filtered[dice.Total-1];
        }
        return GetRandomEntry();
    }

    /// <summary>
    /// Get a entry from the table by it's name
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public virtual RandomTableRangeEntry? GetEntryByName(string Name)
    {
        var te = Table?.First(t => t.Name == Name);
        return te;
    }

    /// <summary>
    /// Get a entry from the table by it's name
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public virtual RandomTableRangeEntry? GetEntryByNumber(int number)
    {
        var te = Table?.First(t =>
                        t.Range.Start.Value <= number
                     && t.Range.End.Value >= number);

        return te;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public RandomRangeTable()
    {
    }
}
