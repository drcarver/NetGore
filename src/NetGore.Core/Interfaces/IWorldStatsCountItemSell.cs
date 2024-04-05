using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountItemSell
{
    /// <summary>
    /// Amount of this item template that has been 
    /// sold to stores.
    /// </summary>
    public int Count { get; set; }

    /// <summary>
    /// The item template this counter is for.
    /// </summary>
    public ItemTemplate? ItemTemplate { get; set; }
}