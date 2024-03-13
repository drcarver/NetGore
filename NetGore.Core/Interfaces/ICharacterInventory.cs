using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterInventory
{
    Character Character { get; set; }
    Item Item { get; set; }
    InventorySlot Slot { get; set; }
}