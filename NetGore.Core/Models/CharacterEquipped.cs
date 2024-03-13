using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterEquipped : BaseObject, ICharacterEquipped
{
    /// <summary>
    /// The character who the equipped item is on.
    /// </summary>
    [Required]
    [Description("The character who the equipped item is on.")]
    [Comment("The character who the equipped item is on.")]
    public required Character Character { get; set; }

    /// <summary>
    /// Gets or sets the value for the field that maps onto the database column `item_id`.
    /// The underlying database type is `int(11)`.The database column contains the comment: 
    /// "The item that is equipped by the character.".
    /// </summary>
    [Required]
    [Description("The item that is equipped by the character.")]
    [Comment("The item that is equipped by the character.")]
    public required Item Item { get; set; }

    /// <summary>
    /// The slot the equipped item is in.
    /// </summary>
    [Required]
    [Description("The slot the equipped item is in.")]
    [Comment("The slot the equipped item is in.")]
    public required EquipmentSlot Slot { get; set; }
}
