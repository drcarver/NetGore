using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersUser
{
    int Counter { get; set; }
    Character User { get; set; }
    byte UserEventCounter { get; set; }
}