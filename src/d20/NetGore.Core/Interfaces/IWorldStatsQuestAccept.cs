using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsQuestAccept
{
    /// <summary>
    /// The ID of the map this event took place on.
    /// </summary>
    Map? Map { get; set; }

    /// <summary>
    /// The quest that was accepted.
    /// </summary>
    Quest? Quest { get; set; }

    /// <summary>
    /// The ID of the user that accepted the quest.
    /// </summary>
    PlayerCharacter? User { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    DateTime When { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    ushort X { get; set; }

    /// <summary>
    /// The map y coordinate of the user when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    ushort Y { get; set; }
}