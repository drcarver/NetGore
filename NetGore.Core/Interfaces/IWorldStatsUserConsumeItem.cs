using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsUserConsumeItem
{
    /// <summary>
    /// The template ID of the item that was consumed. 
    /// Only valid when the item has a set template ID.
    /// </summary>
    ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// The map the user was on when this event took 
    /// place.
    /// </summary>
    Map? Map { get; set; }

    /// <summary>
    /// The user that this event is related to..
    /// </summary>
    Character? User { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    DateTime When { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this 
    /// event took place.
    /// </summary>
    ushort X { get; set; }

    /// <summary>
    /// The map y coordinate of the user when this event
    /// took place.
    /// </summary>
    ushort Y { get; set; }
}