using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

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
    protected WorldStatsCountItemCreate()
    {
    }
}
