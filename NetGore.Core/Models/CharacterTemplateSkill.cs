using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Enum;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class CharacterTemplateSkill : BaseObject, ICharacterTemplateSkill
{
    /// <summary>
    /// The character template that knows the skill.
    /// </summary>
    [Description("The character template that knows the skill.")]
    public CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The skill the character template knows.
    /// </summary>
    [Description("The skill the character template knows.")]
    public SkillType Skill { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected CharacterTemplateSkill()
    {
    }
}
