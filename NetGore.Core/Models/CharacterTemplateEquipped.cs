using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplateEquipped : BaseObject, ICharacterTemplateEquipped
{
    /// <summary>
    /// The chance of the item being equipped when a 
    /// character is instantiated from this template.
    /// </summary>
    [Required]
    [Description("The chance of the item being equipped when a character is instantiated from this template.")]
    [Comment("The chance of the item being equipped when a character is instantiated from this template.")]
    public required ItemChance Chance { get; set; }

    /// <summary>
    /// The character template.
    /// </summary>
    [Required]
    [Description("The character template.")]
    [Comment("The character template.")]
    public required CharacterTemplate CharacterTemplate { get; set; }

    /// <summary>
    /// The item the character template has equipped.
    /// </summary>
    [Description("The item the character template has equipped.")]
    [Comment("The item the character template has equipped.")]
    public required ItemTemplate ItemTemplate
}
