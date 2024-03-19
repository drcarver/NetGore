using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersShop : BaseObject, IEventCountersShop
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
    public int ShopEventCounter { get; set; }

    /// <summary>
    /// The shop the event occured on.
    /// </summary>
    [Description("The shop the event occured on.")]
    public Shop? Shop { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected EventCountersShop()
    {
    }
}
