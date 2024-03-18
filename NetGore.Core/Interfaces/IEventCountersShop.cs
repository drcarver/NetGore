using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersShop
{
    /// <summary>
    /// The event counter.
    /// </summary>
    int Counter { get; set; }

    /// <summary>
    /// The ID of the event that the counter is for.
    /// </summary>
    int ShopEventCounter { get; set; }

    /// <summary>
    /// The shop the event occured on.
    /// </summary>
    Shop? Shop { get; set; }
}