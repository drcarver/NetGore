using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsUserConsumeItem
{
    ItemTemplate ItemTemplate { get; set; }
    Map? Map { get; set; }
    Character User { get; set; }
    DateTime When { get; set; }
    ushort X { get; set; }
    ushort Y { get; set; }
}