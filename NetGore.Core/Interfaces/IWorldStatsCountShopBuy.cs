using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountShopBuy
{
    int Count { get; set; }
    DateTime LastUpdate { get; set; }
    Shop Shop { get; set; }
}