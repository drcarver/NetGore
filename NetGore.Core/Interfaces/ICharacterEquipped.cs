using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterEquipped
{
    Character Character { get; set; }
    Item Item { get; set; }
    EquipmentSlot Slot { get; set; }
}