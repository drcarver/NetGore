using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsUserShopping
{
    ushort Amount { get; set; }
    Character Character { get; set; }
    int Cost { get; set; }
    ItemTemplate? ItemTemplate { get; set; }
    Map? Map { get; set; }
    int SaleType { get; set; }
    Shop Shop { get; set; }
    DateTime When { get; set; }
    ushort X { get; set; }
    ushort Y { get; set; }
}