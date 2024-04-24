using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface ICharacterTemplateSkill
{
    /// <summary>
    /// The character template that knows the skill.
    /// </summary>
    CharacterTemplate? CharacterTemplate { get; set; }

    /// <summary>
    /// The skill the character template knows.
    /// </summary>
    SkillType Skill { get; set; }
}