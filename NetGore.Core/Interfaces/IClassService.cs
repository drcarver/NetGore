using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IClassService
{
    /// <summary>
    /// Set the class for the player
    /// </summary>
    void SetClass(PlayerCharacter playerCharacter);
}