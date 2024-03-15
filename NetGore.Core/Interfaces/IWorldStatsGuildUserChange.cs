using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsGuildUserChange
{
    Guild? Guild { get; set; }
    Character User { get; set; }
    DateTime When { get; set; }
}