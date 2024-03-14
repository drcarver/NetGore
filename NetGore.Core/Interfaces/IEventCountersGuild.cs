using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersGuild
{
    int Counter { get; set; }
    Guild Guild { get; set; }
    int GuildEventCounter { get; set; }
}