using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using NetGore.Core.Base;
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
    public int Count { get; set; }

    /// <summary>
    /// The template of the item that this counter is 
    /// for.
    /// </summary>
    [Description("The template of the item that this counter is for.")]
    public ItemTemplate? ItemTemplate { get; set; }

    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    protected WorldStatsCountItemBuy()
    {
    }
}
