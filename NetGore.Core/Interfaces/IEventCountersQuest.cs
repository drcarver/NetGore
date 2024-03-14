using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersQuest
{
    int Counter { get; set; }
    Quest Quest { get; set; }
    byte QuestEventCounter { get; set; }
}