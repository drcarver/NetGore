using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplateQuestProvider : BaseObject, ICharacterTemplateQuestProvider
{
    /// <summary>
    /// The character template.
    /// </summary>
    [Required]
    [Description("The character template.")]
    [Comment("The character template.")]
    public required CharacterTemplate CharacterTemplate { get; set; }

    /// <summary>
    /// The quest provided by this character template. 
    /// Only applies for valid quest givers (that is, 
    /// not users).
    /// </summary>
    [Required]
    [Description("The quest provided by this character template. Only applies for valid quest givers (that is, not users).")]
    [Comment("The quest provided by this character template. Only applies for valid quest givers (that is, not users).")]
    public required Quest Quest { get; set; }
}
