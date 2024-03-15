using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class ShopItem : BaseObject, IShopItem
{
    /// <summary>
    /// The item template that this shop sells. Item 
    /// instantiated when sold to shopper.
    /// </summary>
    [Required]
    [Description("The item template that this shop sells. Item instantiated when sold to shopper.")]
    [Comment("The item template that this shop sells. Item instantiated when sold to shopper.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// The shop that the item is for.
    /// </summary>
    [Required]
    [Description("The shop that the item is for.")]
    [Comment("The shop that the item is for.")]
    public required Shop Shop { get; set; }
}
