using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountNpcKillUser : BaseObject, IWorldStatsCountNpcKillUser
{
    /// <summary>
    /// The number of times NPCs of this character 
    /// template have killed the user.
    /// </summary>
    [Description("The number of times NPCs of this character template have killed the user.")]
    [Comment("The number of times NPCs of this character template have killed the user.")]
    public int Count { get; set; }

    /// <summary>
    /// When this counter was last updated.
    /// </summary>
    [Description("When this counter was last updated.")]
    [Comment("When this counter was last updated.")]
    public DateTime LastUpdate { get; set; }

    /// <summary>
    /// The character template this counter is for.
    /// </summary>
    [Required]
    [Description("The character template this counter is for.")]
    [Comment("The character template this counter is for.")]
    public required CharacterTemplate NPCTemplate { get; set; }

    /// <summary>
    /// The character this counter is for (logically,
    /// should be a user).
    /// </summary>
    [Required]
    [Description("The character this counter is for (logically, should be a user).")]
    [Comment("The character this counter is for (logically, should be a user).")]
    public required Character User { get; set; }
}
