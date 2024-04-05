using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IActiveTradeItem
{
    /// <summary>
    /// The character that added the item.
    /// </summary>
    PlayerCharacter? Character { get; set; }

    /// <summary>
    /// The item the character put down.
    /// </summary>
    Item? Item { get; set; }
}