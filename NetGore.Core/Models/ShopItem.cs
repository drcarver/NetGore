using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ShopItem : BaseObject, IShopItem
{
    /// <summary>
    /// The item template that this shop sells. Item 
    /// instantiated when sold to shopper.
    /// </summary>
    [Description("The item template that this shop sells. Item instantiated when sold to shopper.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The shop that the item is for.
    /// </summary>
    [Description("The shop that the item is for.")]
    public Shop? Shop { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ShopItem()
    {
    }
}
