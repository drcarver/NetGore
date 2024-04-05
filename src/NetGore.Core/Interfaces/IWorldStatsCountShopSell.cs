using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountShopSell
{
    /// <summary>
    /// The number of times this shop has purchased 
    /// items (shopper has sold to this shop).
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// Gets or sets the value for the field that maps onto the database column `shop_id`.
    /// The underlying database type is `smallint(5) unsigned`.The database column contains the comment: 
    /// "The shop this counter is for.".
    /// </summary>
    Shop? Shop { get; set; }
}