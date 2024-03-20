using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersGuild : BaseObject, IEventCountersGuild
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
    public int GuildEventCounter { get; set; }

    /// <summary>
    /// The guild the event occured on.
    /// </summary>
    [Description("The guild the event occured on.")]
    public Guild? Guild { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected EventCountersGuild()
    {
    }
}
