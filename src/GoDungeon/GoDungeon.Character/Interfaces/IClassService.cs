using GoDungeon.Character.Interfaces;

namespace D20.Character.Interfaces;

public interface IClassService
{
    /// <summary>
    /// Set the class for the player
    /// </summary>
    void SetClass(ICharacter playerCharacter);
}