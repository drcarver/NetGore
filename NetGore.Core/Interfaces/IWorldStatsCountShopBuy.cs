using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountShopBuy
{
    /// <summary>
    /// The number of times this shop has sold (shopper 
    /// has bought from this shop).
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// The shop this counter is for.
    /// </summary>
    Shop? Shop { get; set; }
}