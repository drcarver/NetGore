using System.ComponentModel;

using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsNpcKillUser
{
    /// <summary>
    /// The ID of the map this event took place on.
    /// </summary>
    Map? Map { get; set; }

    /// <summary>
    /// The template ID of the NPC. Only valid when the NPC has a template ID set.".
    /// </summary>
    CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// The map x coordinate of the NPC when this event 
    /// took place. Only valid when the map_id is not 
    /// null.
    /// </summary>
    ushort NpcX { get; set; }

    /// <summary>
    /// The map y coordinate of the NPC when this event 
    /// took place. Only valid when the map_id is not 
    /// null.
    /// </summary>
    ushort NpcY { get; set; }

    /// <summary>
    /// The user.
    /// </summary>
    Character? User { get; set; }

    /// <summary>
    /// The ID of the user.
    /// </summary>
    Guid UserId { get; set; }

    /// <summary>
    /// The level of the user was when this event 
    /// took place.
    /// </summary>
    short UserLevel { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this event 
    /// took place.
    /// </summary>
    ushort UserX { get; set; }

    /// <summary>
    /// The map y coordinate of the user when this 
    /// event took place.
    /// </summary>
    ushort UserY { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    DateTime When { get; set; }
}