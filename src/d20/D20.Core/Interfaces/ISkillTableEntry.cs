using D20.Core.Enum;

namespace D20.Core.Interfaces;

public interface ISkillTableEntry : IStandardTableEntry
{
    /// <summary>
    /// The skill
    /// </summary>
    SkillEnum Skill { get; }

    /// <summary>
    /// The associated ability
    /// </summary>
    AbilityEnum Ability { get; }

    /// <summary>
    /// The skill points for the skill
    /// </summary>
    int Points { get; set; }
}