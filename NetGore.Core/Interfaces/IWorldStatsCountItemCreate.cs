using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountItemCreate
{
    /// <summary>
    /// The total number of times this item has been 
    /// instantiated. When instantiating multiple 
    /// items at once, this is incremented by the 
    /// amount of the item, not just one.
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// The item template this counter is for.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }
}