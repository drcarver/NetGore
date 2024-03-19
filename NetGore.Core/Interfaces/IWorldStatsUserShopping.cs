using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsUserShopping
{
    /// <summary>
    /// The number of items involved in the transaction. 
    /// Should always be greater than 0, and should 
    /// only be greater for 1 for items that can stack.
    /// </summary>
    ushort Amount { get; set; }

    /// <summary>
    /// The ID of the character that performed this 
    /// transaction with the shop.
    /// </summary>
    Character? Character { get; set; }

    /// <summary>
    /// The amount of money that was involved in this 
    /// transaction (how much the shopper sold the
    /// items for, or how much they bought the items for).
    /// </summary>
    int Cost { get; set; }

    /// <summary>
    /// The ID of the item template that the event 
    /// relates to. Only valid when the item involved 
    /// has a set item template ID.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The ID of the map the event took place on.
    /// </summary>
    Map? Map { get; set; }

    /// <summary>
    /// Whether the shop sold to the user, or vise versa.
    /// If 0, the shop sold an item to the shopper. If 
    /// non-zero, the shopper sold an item to a shop.
    /// </summary>
    int SaleType { get; set; }

    /// <summary>
    /// The ID of the shop the event took place at.
    /// </summary>
    Shop? Shop { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    DateTime When { get; set; }

    /// <summary>
    /// The map X coordinate of the shopper when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    ushort X { get; set; }

    /// <summary>
    /// The map Y coordinate of the shopper when 
    /// this event took place. Only valid when the 
    /// map_id is not null.
    /// </summary>
    ushort Y { get; set; }
}