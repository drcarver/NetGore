using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsUserConsumeItem : BaseObject, IWorldStatsUserConsumeItem
{
    /// <summary>
    /// The template ID of the item that was consumed. 
    /// Only valid when the item has a set template ID.
    /// </summary>
    [Required]
    [Description("The template ID of the item that was consumed. Only valid when the item has a set template ID.")]
    [Comment("The template ID of the item that was consumed. Only valid when the item has a set template ID.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// The map the user was on when this event took 
    /// place.
    /// </summary>
    [Description("The map the user was on when this event took place.")]
    [Comment("The map the user was on when this event took place.")]
    public Map? Map { get; set; }

    /// <summary>
    /// The user that this event is related to..
    /// </summary>
    [Required]
    [Description("The user that this event is related to.")]
    [Comment("The user that this event is related to.")]
    public required Character User { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    [Description("When this event took place.")]
    [Comment("When this event took place.")]
    public DateTime When { get; set; }

    /// <summary>
    /// The map x coordinate of the user when this 
    /// event took place.
    /// </summary>
    [Description("The map x coordinate of the user when this event took place.")]
    [Comment("The map x coordinate of the user when this event took place.")]
    public ushort X { get; set; }

    /// <summary>
    /// The map y coordinate of the user when this event
    /// took place.
    /// </summary>
    [Description("The map y coordinate of the user when this event took place.")]
    [Comment("The map y coordinate of the user when this event took place.")]
    public ushort Y { get; set; }
}
