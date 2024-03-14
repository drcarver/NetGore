using NetGore.Core.Enum;
using NetGore.Core.Models;

namespace NetGore.Core.Interfaces
{
    public interface ICharacterTemplateSkill
    {
        CharacterTemplate CharacterTemplate { get; set; }
        SkillType Skill { get; set; }
    }
}