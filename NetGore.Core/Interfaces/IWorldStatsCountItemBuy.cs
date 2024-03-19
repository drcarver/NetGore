using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountItemBuy
{
    /// <summary>
    /// The amount of this item that has been purchased 
    /// from shops. When buying in bulk, this still 
    /// updates by amount bought (so number of items 
    /// purchased, not individual transactions).
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// The template of the item that this counter is 
    /// for.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }
}