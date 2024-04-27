using D20.Core.Interfaces;

namespace D20.Character.Interfaces;

public interface ICharacterAdvancementEntry : IGameTableEntry
{
    /// <summary>
    /// The experience points for the range
    /// </summary>
    Range ExperiencePoints { get; }

    /// <summary>
    /// The level
    /// </summary>
    int Level { get; }

    /// <summary>
    /// The Proficiency Bonus
    /// </summary>
    int ProficiencyBonus { get; }
}