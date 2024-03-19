using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountConsumeItem
{
    /// <summary>
    /// Number of times items of this template have 
    /// been consumed.
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// The item template the counter is for.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }
}