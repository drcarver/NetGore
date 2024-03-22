using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersUser
{
    /// <summary>
    /// The event counter.
    /// </summary>
    int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for.
    /// </summary>
    int UserEventCounter { get; set; }

    /// <summary>
    /// The user character the event occured on.
    /// </summary>
    PlayerCharacter? User { get; set; }
}