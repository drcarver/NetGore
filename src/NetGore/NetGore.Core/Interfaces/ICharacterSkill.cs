using NetGore.Core.Enum;

namespace NetGore.Core.Interfaces;

public interface ICharacterSkill
{
    /// <summary>
    /// The character that knows the skill.
    /// </summary>
    IPlayerCharacter Character { get; set; }

    /// <summary>
    /// The skill the character knows.
    /// </summary>
    Skill Skill { get; set; }

    /// <summary>
    /// When this row was added.
    /// </summary>
    DateTime TimeAdded { get; set; }
}