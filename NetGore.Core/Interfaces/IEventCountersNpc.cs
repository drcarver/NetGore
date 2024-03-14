using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersNpc
{
    int Counter { get; set; }
    byte NPCEventCounter { get; set; }
    CharacterTemplate NPCTemplate { get; set; }
}