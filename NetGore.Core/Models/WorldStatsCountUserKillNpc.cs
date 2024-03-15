using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountUserKillNpc : BaseObject, IWorldStatsCountUserKillNpc
{
    /// <summary>
    /// Total number of NPCs killed by this user.
    /// </summary>
    [Description("Total number of NPCs killed by this user.")]
    [Comment("Total number of NPCs killed by this user.")]
    public int Count { get; set; }

    /// <summary>
    /// When this counter was last updated.
    /// </summary>
    [Description("When this counter was last updated.")]
    [Comment("When this counter was last updated.")]
    public DateTime LastUpdate { get; set; }

    /// <summary>
    /// The character template that this NPC kill 
    /// counter is for.
    /// </summary>
    [Required]
    [Description("The character template that this NPC kill counter is for.")]
    [Comment("The character template that this NPC kill counter is for.")]
    public required CharacterTemplate NPCTemplate { get; set; }

    /// <summary>
    /// The user that this kill counter is for.
    /// </summary>
    [Required]
    [Description("The user that this kill counter is for.")]
    [Comment("The user that this kill counter is for.")]
    public required Character User { get; set; }
}
