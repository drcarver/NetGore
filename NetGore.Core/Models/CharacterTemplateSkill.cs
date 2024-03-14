using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplateSkill : BaseObject, ICharacterTemplateSkill
{
    /// <summary>
    /// The character template that knows the skill.
    /// </summary>
    [Required]
    [Description("The character template that knows the skill.")]
    [Comment("The character template that knows the skill.")]
    public required CharacterTemplate CharacterTemplate { get; set; }

    /// <summary>
    /// The skill the character template knows.
    /// </summary>
    [Description("The skill the character template knows.")]
    [Comment("The skill the character template knows.")]
    public SkillType Skill { get; set; }
}
