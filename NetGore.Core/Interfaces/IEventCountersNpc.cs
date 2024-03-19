using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersNpc
{
    /// <summary>
    /// The event counter.
    /// </summary>
    int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for.
    /// </summary>
    int NPCEventCounter { get; set; }

    /// <summary>
    /// The character template of the NPC the event 
    /// occured on.
    /// </summary>
    CharacterTemplate? NPCTemplate { get; set; }
}