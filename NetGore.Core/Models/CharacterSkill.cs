using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterSkill : BaseObject, ICharacterSkill
{
    /// <summary>
    /// The character that knows the skill.
    /// </summary>
    [Required]
    [Description("The character that knows the skill.")]
    [Comment("The character that knows the skill.")]
    public required Character Character { get; set; }

    /// <summary>
    /// The skill the character knows.
    /// </summary>
    [Required]
    [Description("The skill the character knows.")]
    [Comment("The skill the character knows.")]
    public required Skill Skill { get; set; }

    /// <summary>
    /// When this row was added.
    /// </summary>
    [Required]
    [Description("When this row was added.")]
    [Comment("When this row was added.")]
    public required DateTime TimeAdded { get; set; }
}
