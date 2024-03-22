using NetGore.Core.Models;

namespace NetGore.Data.Interfaces;

public interface IRaceService
{
    /// <summary>
    /// Get the race of the creature
    /// </summary>
    void SetRace(PlayerCharacter creature);
}