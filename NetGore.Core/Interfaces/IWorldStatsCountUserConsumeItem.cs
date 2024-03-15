using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountUserConsumeItem
{
    int Count { get; set; }
    ItemTemplate ItemTemplate { get; set; }
    DateTime LastUpdate { get; set; }
    Character User { get; set; }
}