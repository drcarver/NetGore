using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersShop
{
    int Counter { get; set; }
    Shop Shop { get; set; }
    byte ShopEventCounter { get; set; }
}