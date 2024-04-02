using NetGore.Data.Models;

namespace NetGore.Data.Interfaces;

public interface ICharacterAdvancement
{
    /// <summary>
    /// Number of levels
    /// </summary>
    int DiceSides { get; set; }

    /// <summary>
    /// The table
    /// </summary>
    List<CharacterAdvancementEntry>? Table { get; set; }

    /// <summary>
    /// Get a entry by it's experience points
    /// </summary>
    /// <param name="number">The experience points</param>
    /// <returns>experience points in the range</returns>
    CharacterAdvancementEntry? GetEntryByExperiencePoints(int number);
    
    /// <summary>
    /// Get a entry by its level
    /// </summary>
    /// <param name="level"></param>
    /// <returns>The entry with the given level</returns>
    CharacterAdvancementEntry? GetEntryByLevel(int level);
    
    /// <summary>
    /// Get a random entry
    /// </summary>
    /// <returns>The random entry</returns>
    CharacterAdvancementEntry? GetRandomEntry();
}