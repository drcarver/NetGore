using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountUserConsumeItem : BaseObject, IWorldStatsCountUserConsumeItem
{
    /// <summary>
    /// The amount of the item that the user has consumed.
    /// </summary>
    [Description("The amount of the item that the user has consumed.")]
    [Comment("The amount of the item that the user has consumed.")]
    public int Count { get; set; }

    /// <summary>
    /// The item template that this consumption counter 
    /// is for.
    /// </summary>
    [Required]
    [Description("The item template that this consumption counter is for.")]
    [Comment("The item template that this consumption counter is for.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// When this counter was last updated..
    /// </summary>
    [Description("When this counter was last updated.")]
    [Comment("When this counter was last updated.")]
    public DateTime LastUpdate { get; set; }

    /// <summary>
    /// Character this counter is for. Logically, it 
    /// should be a user (not persistent NPC).
    /// </summary>
    [Required]
    [Description("Character this counter is for. Logically, it should be a user (not persistent NPC).")]
    [Comment("Character this counter is for. Logically, it should be a user (not persistent NPC).")]
    public required Character User { get; set; }
}
