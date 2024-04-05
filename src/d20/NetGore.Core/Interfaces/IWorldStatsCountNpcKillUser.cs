using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountNpcKillUser
{
    /// <summary>
    /// The number of times NPCs of this character 
    /// template have killed the user.
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// The character template this counter is for.
    /// </summary>
    CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// The character this counter is for (logically,
    /// should be a user).
    /// </summary>
    PlayerCharacter? User { get; set; }
}