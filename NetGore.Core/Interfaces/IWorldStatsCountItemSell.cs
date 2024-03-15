using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountItemSell
{
    int Count { get; set; }
    ItemTemplate ItemTemplate { get; set; }
    DateTime LastUpdate { get; set; }
}