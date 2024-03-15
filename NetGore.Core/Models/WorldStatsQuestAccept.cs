using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsQuestAccept : BaseObject, IWorldStatsQuestAccept
{
    /// <summary>
    /// The ID of the map this event took place on.
    /// </summary>
    [Required]
    [Description("The ID of the map this event took place on.")]
    [Comment("The ID of the map this event took place on.")]
    public required Map Map { get; set; }

    /// <summary>
    /// The quest that was accepted.
    /// </summary>
    [Required]
    [Description("The quest that was accepted.")]
    [Comment("The quest that was accepted.")]
    public required Quest Quest { get; set; }

    /// <summary>
    /// The ID of the user that accepted the quest.
    /// </summary>
    [Required]
    [Description("The ID of the user that accepted the quest.")]
    [Comment("The ID of the user that accepted the quest.")]
    public required Character User { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    [Description("When this event took place.")]
    [Comment("When this event took place.")]
    public DateTime When { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    [Description("The map x coordinate of the user when this event took place. Only valid when the map_id is not null.")]
    [Comment("The map x coordinate of the user when this event took place. Only valid when the map_id is not null.")]
    public ushort X { get; set; }

    /// <summary>
    /// The map y coordinate of the user when this 
    /// event took place. Only valid when the map_id 
    /// is not null.
    /// </summary>
    [Description("The map y coordinate of the user when this event took place. Only valid when the map_id is not null.")]
    [Comment("The map y coordinate of the user when this event took place. Only valid when the map_id is not null.")]
    public ushort Y { get; set; }
}
