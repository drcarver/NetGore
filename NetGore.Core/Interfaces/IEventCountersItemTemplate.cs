using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IEventCountersItemTemplate
{
    int Counter { get; set; }
    ItemTemplate ItemTemplate { get; set; }
}