using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountItemCreate : BaseObject, IWorldStatsCountItemCreate
{
    /// <summary>
    /// The total number of times this item has been 
    /// instantiated. When instantiating multiple 
    /// items at once, this is incremented by the 
    /// amount of the item, not just one.
    /// </summary>
    [Description("The total number of times this item has been instantiated. When instantiating multiple items at once, this is incremented by the amount of the item, not just one.")]
    [Comment("The total number of times this item has been instantiated. When instantiating multiple items at once, this is incremented by the amount of the item, not just one.")]
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
