using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersGuild
{
    /// <summary>
    /// The event counter.
    /// </summary>
    int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for.
    /// </summary>
    int GuildEventCounter { get; set; }

    /// <summary>
    /// The guild the event occured on.
    /// </summary>
    Guild? Guild { get; set; }
}