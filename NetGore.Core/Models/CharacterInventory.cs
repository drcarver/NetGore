using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterInventory : BaseObject, ICharacterInventory
{
    /// <summary>
    /// The character who has this item in their inventory.
    /// </summary>
    [Description("The character who has this item in their inventory.")]
    public PlayerCharacter? Character { get; set; }

    /// <summary>
    /// The item that is in the character's inventory.
    /// </summary>
    [Description("The item that is in the character's inventory.")]
    public Item? Item { get; set; }

    /// <summary>
    /// The slot the item is in.
    /// </summary>
    [Description("The slot the item is in.")]
    public InventorySlot? Slot { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterInventory()
    {
    }
}
