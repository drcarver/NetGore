using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsGuildUserChange
{
    /// <summary>
    /// The ID of the guild, or null if the user left
    /// a guild.
    /// </summary>
    Guild? Guild { get; set; }

    /// <summary>
    /// The ID of the user who changed the guild they 
    /// are part of.
    /// </summary>
    Character? User { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    DateTime When { get; set; }
}