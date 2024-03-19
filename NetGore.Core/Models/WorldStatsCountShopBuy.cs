using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountShopBuy : BaseObject, IWorldStatsCountShopBuy
{
    /// <summary>
    /// The number of times this shop has sold (shopper 
    /// has bought from this shop).
    /// </summary>
    [Description("The number of times this shop has sold (shopper has bought from this shop).")]
    public int Count { get; set; }

    /// <summary>
    /// The shop this counter is for.
    /// </summary>
    [Description("The shop this counter is for.")]
    public Shop? Shop { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsCountShopBuy()
    {
    }
}
