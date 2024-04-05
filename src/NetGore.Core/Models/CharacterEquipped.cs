using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterEquipped : BaseObject, ICharacterEquipped
{
    /// <summary>
    /// The character who the equipped item is on.
    /// </summary>
    [Description("The character who the equipped item is on.")]
    public PlayerCharacter? Character { get; set; }

    /// <summary>
    /// Gets or sets the value for the field that maps onto the database column `item_id`.
    /// The underlying database type is `int(11)`.The database column contains the comment: 
    /// "The item that is equipped by the character.".
    /// </summary>
    [Description("The item that is equipped by the character.")]
    public Item? Item { get; set; }

    /// <summary>
    /// The slot the equipped item is in.
    /// </summary>
    [Description("The slot the equipped item is in.")]
    public EquipmentSlot? Slot { get; set; }

    /// <summary>
    /// Create a new CharacterEquipped
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterEquipped()
    {
    }
}
