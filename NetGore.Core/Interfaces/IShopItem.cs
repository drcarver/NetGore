using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IShopItem
{
    ItemTemplate ItemTemplate { get; set; }
    Shop Shop { get; set; }
}