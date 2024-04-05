using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IRace
{
    /// <summary>
    /// Generate the character background
    /// </summary>
    void GenerateRaceBackground(Character character);
}