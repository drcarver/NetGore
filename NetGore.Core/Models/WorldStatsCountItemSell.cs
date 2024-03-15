using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountItemSell : BaseObject, IWorldStatsCountItemSell
{
    /// <summary>
    /// Amount of this item template that has been 
    /// sold to stores.
    /// </summary>
    [Description("Amount of this item template that has been sold to stores.")]
    [Comment("Amount of this item template that has been sold to stores.")]
    public int Count { get; set; }

    /// <summary>
    /// The item template this counter is for.
    /// </summary>
    [Required]
    [Description("The item template this counter is for.")]
    [Comment("The item template this counter is for.")]
    public required ItemTemplate ItemTemplate { get; set; }

    /// <summary>
    /// When this counter was last updated.
    /// </summary>
    [Description("When this counter was last updated.")]
    [Comment("When this counter was last updated.")]
    public DateTime LastUpdate { get; set; }
}
