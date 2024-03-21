using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public interface IPlayerCharacter
{
    /// <summary>
    /// The character class
    /// </summary>
    ICharacterClass? CharacterClass { get; set; }

    /// <summary>
    /// The account for the player who owns this
    /// character
    /// </summary>
    IAccount? Account { get; set; }
}