using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsUserLevel
{
    /// <summary>
    /// The ID of the character that leveled up.
    /// </summary>
    Character? Character { get; set; }

    /// <summary>
    /// The level that the character leveled up to 
    /// (their new level).
    /// </summary>
    short Level { get; set; }

    /// <summary>
    /// The ID of the map this event took place on.
    /// </summary>
    Map? Map { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    DateTime When { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this event 
    /// took place. Only valid when the map_id is not 
    /// null.
    /// </summary>
    ushort X { get; set; }

    /// <summary>
    /// The map y coordinate of the user when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    ushort Y { get; set; }
}