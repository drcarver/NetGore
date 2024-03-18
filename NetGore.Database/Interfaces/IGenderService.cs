using NetGore.Core.Base;

namespace NetGore.Database.Interfaces;

public interface IGenderService
{
    /// <summary>
    /// Get the Gender of the creature
    /// </summary>
    /// <returns>The selected Gender</returns>
    Gender? GetGender();
}