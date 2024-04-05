using NetGore.Core.Interfaces;

namespace NetGore.Data.Interfaces;

public interface ICharacterAdvancementEntry : IGameTableEntry
{
    /// <summary>
    /// The level
    /// </summary>
    int Level { get; set; }

    /// <summary>
    /// The Proficiency Bonus
    /// </summary>
    int ProficiencyBonus { get; set; }
}