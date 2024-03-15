using System.ComponentModel;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountConsumeItem : BaseObject, IWorldStatsCountConsumeItem
{
    /// <summary>
    /// Number of times items of this template have 
    /// been consumed.
    /// </summary>
    [Description("Number of times items of this template have been consumed.")]
    [Comment("Number of times items of this template have been consumed.")]
    public int Count { get; set; }

    /// <summary>
    /// The item template the counter is for.
    /// </summary>
    [Description("The item template the counter is for.")]
    [Comment("The item template the counter is for.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// When this counter was last updated.
    /// </summary>
    [Description("When this counter was last updated.")]
    [Comment("When this counter was last updated.")]
    public DateTime LastUpdate { get; set; }
}
