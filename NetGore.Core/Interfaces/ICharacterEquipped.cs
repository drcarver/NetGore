using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterEquipped
{
    /// <summary>
    /// The character who the equipped item is on.
    /// </summary>
    PlayerCharacter? Character { get; set; }

    /// <summary>
    /// Gets or sets the value for the field that maps onto the database column `item_id`.
    /// The underlying database type is `int(11)`.The database column contains the comment: 
    /// "The item that is equipped by the character.".
    /// </summary>
    Item? Item { get; set; }

    /// <summary>
    /// The slot the equipped item is in.
    /// </summary>
    EquipmentSlot? Slot { get; set; }
}