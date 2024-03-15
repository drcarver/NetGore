using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

using Microsoft.EntityFrameworkCore;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountShopBuy : BaseObject, IWorldStatsCountShopBuy
{
    /// <summary>
    /// The number of times this shop has sold (shopper 
    /// has bought from this shop).
    /// </summary>
    [Description("The number of times this shop has sold (shopper has bought from this shop).")]
    [Comment("The number of times this shop has sold (shopper has bought from this shop).")]
    public int Count { get; set; }

    /// <summary>
    /// When this counter was last updated.
    /// </summary>
    [Description("When this counter was last updated.")]
    [Comment("When this counter was last updated.")]
    public DateTime LastUpdate { get; set; }

    /// <summary>
    /// The shop this counter is for.
    /// </summary>
    [Required]
    [Description("The shop this counter is for.")]
    [Comment("The shop this counter is for.")]
    public required Shop Shop { get; set; }
}
