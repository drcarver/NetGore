using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsQuestComplete
{
    Map? Map { get; set; }
    Quest Quest { get; set; }
    Character User { get; set; }
    DateTime When { get; set; }
    ushort X { get; set; }
    ushort Y { get; set; }
}