using System.Diagnostics.CodeAnalysis;

using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class MiscellaneousItem : GoodsTableEntry, IMiscellaneousItem
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public MiscellaneousItem()
    {
    }

    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    /// The quantity of the ammunition
    /// </summary>
    public int Quantity { get; set; }
}
