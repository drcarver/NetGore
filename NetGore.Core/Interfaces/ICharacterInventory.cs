using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterInventory
{
    /// <summary>
    /// The character who has this item in their inventory.
    /// </summary>
    Character? Character { get; set; }

    /// <summary>
    /// The item that is in the character's inventory.
    /// </summary>
    Item? Item { get; set; }

    /// <summary>
    /// The slot the item is in.
    /// </summary>
    [Description("The slot the item is in.")]
    InventorySlot? Slot { get; set; }
}