using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterInventory : BaseObject, ICharacterInventory
{
    /// <summary>
    /// The character who has this item in their inventory.
    /// </summary>
    [Required]
    [Description("The character who has this item in their inventory.")]
    [Comment("The character who has this item in their inventory.")]
    public required Character Character { get; set; }

    /// <summary>
    /// The item that is in the character's inventory.
    /// </summary>
    [Required]
    [Description("The item that is in the character's inventory.")]
    [Comment("The item that is in the character's inventory.")]
    public required Item Item { get; set; }

    /// <summary>
    /// The slot the item is in.
    /// </summary>
    [Required]
    [Description("The slot the item is in.")]
    [Comment("The slot the item is in.")]
    public required InventorySlot Slot { get; set; }
}
