using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
using NetGore.Core.Interfaces;

namespace NetGore.Core.Models;

public class WorldStatsCountItemSell : BaseObject, IWorldStatsCountItemSell
{
    /// <summary>
    /// Amount of this item template that has been 
    /// sold to stores.
    /// </summary>
    [Description("Amount of this item template that has been sold to stores.")]
    public int Count { get; set; }

    /// <summary>
    /// The item template this counter is for.
    /// </summary>
    [Description("The item template this counter is for.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsCountItemSell()
    {
    }
}
