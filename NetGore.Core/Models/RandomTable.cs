using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class RandomTable : BaseObject, IRandomTable
{
    /// <summary>
    /// The sides to the dice for the table
    /// </summary>
    public int DiceSides { get; set; } = 100;

    /// <summary>
    /// The actual table
    /// </summary>
    public List<RandomTableEntry>? Table { get; set; }

    /// <summary>
    /// Get a entry from the table based on a random dice 
    /// roll
    /// </summary>
    /// <returns>The selected RandomTableEntry as a BaseObject</returns>
    public virtual RandomTableEntry? GetRandomEntry()
    {
        if (Table == null)
        {
            return null;
        }

        Dice dice = new($"1d{DiceSides}");
        return Table.FirstOrDefault(t =>
                        t.LowerRange >= dice.Total
                     && t.UpperRange <= dice.Total);
    }
}
