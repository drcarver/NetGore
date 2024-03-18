using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersQuest
{
    /// <summary>
    /// The event counter.
    /// </summary>
    int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for
    /// </summary>
    int QuestEventCounter { get; set; }

    /// <summary>
    /// The quest the event occured on.
    /// </summary>
    Quest? Quest { get; set; }
}