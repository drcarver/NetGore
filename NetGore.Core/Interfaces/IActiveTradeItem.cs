using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IActiveTradeItem
{
    Character Character { get; set; }
    Item Item { get; set; }
}