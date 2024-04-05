using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersMap
{
    /// <summary>
    /// The event counter.
    /// </summary>
    int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for.
    /// </summary>
    int MapEventCounterId { get; set; }

    /// <summary>
    /// The map the event occured on.
    /// </summary>
    Map? Map { get; set; }
}