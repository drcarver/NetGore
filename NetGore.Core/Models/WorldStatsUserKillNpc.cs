using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsUserKillNpc : BaseObject, IWorldStatsUserKillNpc
{
    /// <summary>
    /// The ID of the map this event took place on.
    /// </summary>
    [Description("The ID of the map this event took place on.")]
    public Map? Map { get; set; }

    /// <summary>
    /// The template ID of the NPC. Only valid when 
    /// the NPC has a template ID set.
    /// </summary>
    [Description("The template ID of the NPC. Only valid when the NPC has a template ID set.")]
    public CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// The map x coordinate of the NPC when this event 
    /// took place. Only valid when the map_id is not 
    /// null.
    /// </summary>
    [Description("The map x coordinate of the NPC when this event took place. Only valid when the map_id is not null.")]
    public ushort NpcX { get; set; }

    /// <summary>
    /// The map y coordinate of the NPC when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    [Description("The map y coordinate of the NPC when this event took place. Only valid when the map_id is not null.")]
    public ushort NpcY { get; set; }

    /// <summary>
    /// The ID of the user.
    /// </summary>
    [Description("The ID of the user.")]
    public Character? User { get; set; }

    /// <summary>
    /// The level of the user was when this event took
    /// place.
    /// </summary>
    [Description("The level of the user was when this event took place.")]
    public short UserLevel { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    [Description("The map x coordinate of the user when this event took place. Only valid when the map_id is not null.")]
    public ushort UserX { get; set; }

    /// <summary>
    /// Gets or sets the value for the field that maps onto the database column `user_y`.
    /// The underlying database type is `smallint(5) unsigned`.The database column contains the comment: 
    /// "The map y coordinate of the user when this event took place. Only valid when the map_id is not null.".
    /// </summary>
    [Description("The map y coordinate of the user when this event took place. Only valid when the map_id is not null.")]
    public ushort UserY { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    [Description("When this event took place.")]
    public DateTime When { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsUserKillNpc()
    {
    }
}
