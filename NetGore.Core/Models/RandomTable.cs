using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
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
        Total = dice.Total;

        var te = Table?.First(t =>
                        t.LowerRange <= Total
                     && t.UpperRange >= Total);

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
