using D20.Gaming.Interfaces;

namespace D20.Gaming.Models;

public class CharacterWealthByLevelEntry : ICharacterWealthByLevelEntry
{
    /// <summary>
    /// Character level
    /// </summary>
    public int Level { get; set; }

    /// <summary>
    /// Wealth in gold pieces
    /// </summary>
    public int Wealth { get; set; }
}
