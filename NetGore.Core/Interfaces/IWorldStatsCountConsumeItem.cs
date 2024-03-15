using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountConsumeItem
{
    int Count { get; set; }
    ItemTemplate ItemTemplate { get; set; }
    DateTime LastUpdate { get; set; }
}