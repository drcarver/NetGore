using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplateInventory : BaseObject, ICharacterTemplateInventory
{
    /// <summary>
    /// Chance that this item will be created when the 
    /// character template is instantiated. Item quantity 
    /// will be between min and max (equal chance 
    /// distribution).
    /// </summary>
    [Required]
    [Description("Chance that this item will be created when the character template is instantiated. Item quantity will be between min and max (equal chance distribution).")]
    [Comment("Chance that this item will be created when the character template is instantiated. Item quantity will be between min and max (equal chance distribution).")]
    public required ItemChance Chance { get; set; }

    /// <summary>
    /// The character template.
    /// </summary>
    [Required]
    [Description("The character template.")]
    [Comment("The character template.")]
    public required CharacterTemplate CharacterTemplate { get; set; }

    /// <summary>
    /// The item the character template has in their 
    /// inventory.
    /// </summary>
    [Required]
    [Description("The item the character template has in their inventory.")]
    [Comment("The item the character template has in their inventory.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// The maximum number of items to be created.
    /// </summary>
    [Description("The maximum number of items to be created.")]
    [Comment("The maximum number of items to be created.")]
    public byte Max { get; set; }

    /// <summary>
    /// The minimum number of items to be created. Doesn't 
    /// affect item creation chance. Each value in range 
    /// has equal distribution.
    /// </summary>
    [Description("The minimum number of items to be created. Doesn't affect item creation chance. Each value in range has equal distribution.")]
    [Comment("The minimum number of items to be created. Doesn't affect item creation chance. Each value in range has equal distribution.")]
    public byte Min { get; set; }
}
