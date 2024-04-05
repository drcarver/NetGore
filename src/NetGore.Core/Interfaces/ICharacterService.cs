using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

/// <summary>
/// The character service
/// </summary>
public interface ICharacterService
{
    /// <summary>
    /// Create a new character
    /// </summary>
    /// <returns></returns>
    Character CreateCharacter();
}