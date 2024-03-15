using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountShopSell : BaseObject, IWorldStatsCountShopSell
{
    /// <summary>
    /// The number of times this shop has purchased 
    /// items (shopper has sold to this shop).
    /// </summary>
    [Description("The number of times this shop has purchased items (shopper has sold to this shop).")]
    [Comment("The number of times this shop has purchased items (shopper has sold to this shop).")]
    public int Count { get; set; }

    /// <summary>
    /// When this counter was last updated.
    /// </summary>
    [Description("When this counter was last updated.")]
    [Comment("When this counter was last updated.")]
    public DateTime LastUpdate { get; set; }

    /// <summary>
    /// Gets or sets the value for the field that maps onto the database column `shop_id`.
    /// The underlying database type is `smallint(5) unsigned`.The database column contains the comment: 
    /// "The shop this counter is for.".
    /// </summary>
    [Required]
    [Description("The shop this counter is for.")]
    [Comment("The shop this counter is for.")]
    public required Shop Shop { get; set; }
}
