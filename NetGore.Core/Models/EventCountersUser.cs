using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersUser : BaseObject, IEventCountersUser
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
    public int UserEventCounter { get; set; }

    /// <summary>
    /// The user character the event occured on.
    /// </summary>
    [Description("The user character the event occured on.")]
    public Character? User { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected EventCountersUser()
    {
    }
}
