using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsUserLevel : BaseObject, IWorldStatsUserLevel
{
    /// <summary>
    /// The ID of the character that leveled up.
    /// </summary>
    [Required]
    [Description("The ID of the character that leveled up.")]
    [Comment("The ID of the character that leveled up.")]
    public required Character Character { get; set; }

    /// <summary>
    /// The level that the character leveled up to 
    /// (their new level).
    /// </summary>
    [Description("The level that the character leveled up to (their new level).")]
    [Comment("The level that the character leveled up to (their new level).")]
    public short Level { get; set; }

    /// <summary>
    /// The ID of the map this event took place on.
    /// </summary>
    [Description("The ID of the map this event took place on.")]
    [Comment("The ID of the map this event took place on.")]
    public Map? Map { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    [Description("When this event took place.")]
    [Comment("When this event took place.")]
    public DateTime When { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this event 
    /// took place. Only valid when the map_id is not 
    /// null.
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
