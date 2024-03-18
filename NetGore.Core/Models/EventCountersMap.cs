using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersMap : BaseObject, IEventCountersMap
{
    /// <summary>
    /// The event counter.
    /// </summary>
    [Description("The event counter.")]
    public int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for.
    /// </summary>
    [Description("The ID of the event that the counter is for.")]
    public int MapEventCounterId { get; set; }

    /// <summary>
    /// The map the event occured on.
    /// </summary>
    [Description("The map the event occured on.")]
    public Map? Map { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected EventCountersMap()
    {
    }
}
