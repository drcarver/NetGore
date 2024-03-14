using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersMap
{
    int Counter { get; set; }
    Map Map { get; set; }
    byte MapEventCounterId { get; set; }
}