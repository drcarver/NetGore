using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsGuildUserChange : BaseObject, IWorldStatsGuildUserChange
{
    /// <summary>
    /// The ID of the guild, or null if the user left
    /// a guild.
    /// </summary>
    [Description("The ID of the guild, or null if the user left a guild.")]
    [Comment("The ID of the guild, or null if the user left a guild.")]
    public Guild? Guild { get; set; }

    /// <summary>
    /// The ID of the user who changed the guild they 
    /// are part of.
    /// </summary>
    [Required]
    [Description("The ID of the user who changed the guild they are part of.")]
    [Comment("The ID of the user who changed the guild they are part of.")]
    public required Character User { get; set; }

    /// <summary>
    /// When this event took place.
    /// </summary>
    [Description("When this event took place.")]
    [Comment("When this event took place.")]
    public DateTime When { get; set; }
}
