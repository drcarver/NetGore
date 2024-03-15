using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsNpcKillUser : BaseObject, IWorldStatsNpcKillUser
{
    /// <summary>
    /// The ID of the map this event took place on.
    /// </summary>
    [Description("The ID of the map this event took place on.")]
    [Comment("The ID of the map this event took place on.")]
    public Map? Map { get; set; }

    /// <summary>
    /// The template ID of the NPC. Only valid when the NPC has a template ID set.".
    /// </summary>
    [Description("The template ID of the NPC. Only valid when the NPC has a template ID set.")]
    [Comment("The template ID of the NPC. Only valid when the NPC has a template ID set.")]
    public CharacterTemplate? NPCTemplate { get; set; }

    /// <summary>
    /// The map x coordinate of the NPC when this event 
    /// took place. Only valid when the map_id is not 
    /// null.
    /// </summary>
    [Description("The map x coordinate of the NPC when this event took place. Only valid when the map_id is not null.")]
    [Comment("The map x coordinate of the NPC when this event took place. Only valid when the map_id is not null.")]
    public ushort NpcX { get; set; }

    /// <summary>
    /// The map y coordinate of the NPC when this event 
    /// took place. Only valid when the map_id is not 
    /// null.
    /// </summary>
    [Description("The map y coordinate of the NPC when this event took place. Only valid when the map_id is not null.")]
    [Comment("The map y coordinate of the NPC when this event took place. Only valid when the map_id is not null.")]
    public ushort NpcY { get; set; }

    /// <summary>
    /// The user.
    /// </summary>
    [Required]
    [Description("The user.")]
    [Comment("The user.")]
    public virtual required Character User { get; set; }

    /// <summary>
    /// The ID of the user.
    /// </summary>
    [Description("The ID of the user.")]
    [Comment("The ID of the user.")]
    public Guid UserId { get; set; }

    /// <summary>
    /// The level of the user was when this event 
    /// took place.
    /// </summary>
    [Description("The level of the user was when this event took place.")]
    [Comment("The level of the user was when this event took place.")]
    public short UserLevel { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this event 
    /// took place.
    /// </summary>
    [Description("The map x coordinate of the user when this event took place.")]
    [Comment("The map x coordinate of the user when this event took place.")]
    public ushort UserX { get; set; }

    /// <summary>
    /// The map y coordinate of the user when this 
    /// event took place.
    /// </summary>
    [Description("The map y coordinate of the user when this event took place.")]
    [Comment("The map y coordinate of the user when this event took place.")]
    public ushort UserY { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    [Description("When this event took place.")]
    [Comment("When this event took place.")]
    public DateTime When { get; set; }
}
