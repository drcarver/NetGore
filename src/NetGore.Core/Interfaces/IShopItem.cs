using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IShopItem
{
    /// <summary>
    /// The item template that this shop sells. Item 
    /// instantiated when sold to shopper.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The shop that the item is for.
    /// </summary>
    Shop? Shop { get; set; }
}