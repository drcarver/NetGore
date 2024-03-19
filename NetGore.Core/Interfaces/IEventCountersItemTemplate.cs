using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersItemTemplate
{
    /// <summary>
    /// The event counter.
    /// </summary>
    int Counter { get; set; }

    /// <summary>
    /// The template of the item the event occured on.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }
}