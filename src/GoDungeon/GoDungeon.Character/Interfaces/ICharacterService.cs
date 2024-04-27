using GoDungeon.Character.Interfaces;

namespace D20.Character.Interfaces;

/// <summary>
/// The character service
/// </summary>
public interface ICharacterService
{
    /// <summary>
    /// Create a new character
    /// </summary>
    /// <returns></returns>
    ICharacter CreateCharacter();
}