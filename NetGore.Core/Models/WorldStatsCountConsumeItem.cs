using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountConsumeItem : BaseObject, IWorldStatsCountConsumeItem
{
    /// <summary>
    /// Number of times items of this template have 
    /// been consumed.
    /// </summary>
    [Description("Number of times items of this template have been consumed.")]
    public int Count { get; set; }

    /// <summary>
    /// The item template the counter is for.
    /// </summary>
    [Description("The item template the counter is for.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsCountConsumeItem()
    {
    }
}
