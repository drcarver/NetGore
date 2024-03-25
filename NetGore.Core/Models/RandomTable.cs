using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class RandomTable : BaseObject, IRandomTable
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
    public List<RandomTableEntry>? Table { get; set; }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public virtual RandomTableEntry? GetRandomEntry()
    {
        Dice dice = new($"1d{DiceSides}");
        return GetEntryByNumber(dice.Total);
    }

    /// <summary>
    /// Get a entry from the table based on a random 
    /// dice roll
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public virtual RandomTableEntry? GetRandomEntryByClass(ClassEnum filterclass)
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
    public virtual RandomTableEntry? GetEntryByName(string Name)
    {
        var te = Table?.First(t => t.Name == Name);
        return te;
    }

    /// <summary>
    /// Get a entry from the table by it's name
    /// </summary>
    /// <returns>The selected RandomTableEntry.</returns>
    public virtual RandomTableEntry? GetEntryByNumber(int number)
    {
        var te = Table?.First(t =>
                        t.LowerRange <= number
                     && t.UpperRange >= number);

        return te;
    }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public RandomTable()
    {
    }
}
