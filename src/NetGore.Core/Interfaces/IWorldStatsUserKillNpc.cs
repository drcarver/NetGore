using NetGore.Core.Models;

namespace NetGore.Core.Interfaces;

public interface IWorldStatsUserKillNpc
{
    /// <summary>
    /// The ID of the map this event took place on.
    /// </summary>
    Map? Map { get; set; }

    /// <summary>
    /// The template ID of the NPC. Only valid when 
    /// the NPC has a template ID set.
    /// </summary>
    CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// The map x coordinate of the NPC when this event 
    /// took place. Only valid when the map_id is not 
    /// null.
    /// </summary>
    ushort NpcX { get; set; }

    /// <summary>
    /// The map y coordinate of the NPC when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    ushort NpcY { get; set; }

    /// <summary>
    /// The ID of the user.
    /// </summary>
    PlayerCharacter? User { get; set; }

    /// <summary>
    /// The level of the user was when this event took
    /// place.
    /// </summary>
    short UserLevel { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    ushort UserX { get; set; }

    /// <summary>
    /// Gets or sets the value for the field that maps onto the database column `user_y`.
    /// The underlying database type is `smallint(5) unsigned`.The database column contains the comment: 
    /// "The map y coordinate of the user when this event took place. Only valid when the map_id is not null.".
    /// </summary>
    ushort UserY { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    DateTime When { get; set; }
}