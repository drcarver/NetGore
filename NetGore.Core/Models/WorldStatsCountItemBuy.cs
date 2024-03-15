using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountItemBuy : BaseObject, IWorldStatsCountItemBuy
{
    /// <summary>
    /// The amount of this item that has been purchased 
    /// from shops. When buying in bulk, this still 
    /// updates by amount bought (so number of items 
    /// purchased, not individual transactions).
    /// </summary>
    [Description("The amount of this item that has been purchased from shops. When buying in bulk, this still updates by amount bought (so number of items purchased, not individual transactions).")]
    [Comment("The amount of this item that has been purchased from shops. When buying in bulk, this still updates by amount bought (so number of items purchased, not individual transactions).")]
    public int Count { get; set; }

    /// <summary>
    /// The template of the item that this counter is 
    /// for.
    /// </summary>
    [Required]
    [Description("The template of the item that this counter is for.")]
    [Comment("The template of the item that this counter is for.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// When this counter was last updated.
    /// </summary>
    [Description("When this counter was last updated.")]
    [Comment("When this counter was last updated.")]
    public DateTime LastUpdate { get; set; }
}
