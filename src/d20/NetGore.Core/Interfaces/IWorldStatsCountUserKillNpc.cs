using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsCountUserKillNpc
{
    /// <summary>
    /// Total number of NPCs killed by this user.
    /// </summary>
    int Count { get; set; }

    /// <summary>
    /// The character template that this NPC kill 
    /// counter is for.
    /// </summary>
    CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// The user that this kill counter is for.
    /// </summary>
    PlayerCharacter? User { get; set; }
}