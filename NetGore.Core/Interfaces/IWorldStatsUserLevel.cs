using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsUserLevel
{
    Character Character { get; set; }
    short Level { get; set; }
    Map? Map { get; set; }
    DateTime When { get; set; }
    ushort X { get; set; }
    ushort Y { get; set; }
}