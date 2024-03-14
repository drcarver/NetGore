using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class EventCountersGuild : BaseObject, IEventCountersGuild
{
    /// <summary>
    /// The event counter.
    /// </summary>
    [Description("The event counter.")]
    [Comment("The event counter.")]
    public int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for.
    /// </summary>
    [Description("The ID of the event that the counter is for.")]
    [Comment("The ID of the event that the counter is for.")]
    public int GuildEventCounter { get; set; }

    /// <summary>
    /// The guild the event occured on.
    /// </summary>
    [Required]
    [Description("The guild the event occured on.")]
    [Comment("The guild the event occured on.")]
    public required Guild Guild { get; set; }
}
