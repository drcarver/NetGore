using System.Diagnostics.CodeAnalysis;

using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class BagOf : GoodsTableEntry, IBagOf
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public BagOf()
    {
    }

    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    /// The quantity of the BagOf
    /// </summary>
    public int Quantity { get; set; }
}
