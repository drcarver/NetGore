namespace NetGore.Data.Interfaces;

public interface ICharacterAdvancementEntry
{
    /// <summary>
    /// The experience points for this level
    /// </summary>
    Range ExperiencePoints { get; set; }

    /// <summary>
    /// The level
    /// </summary>
    int Level { get; set; }

    /// <summary>
    /// The Proficiency Bonus
    /// </summary>
    int ProficiencyBonus { get; set; }
}