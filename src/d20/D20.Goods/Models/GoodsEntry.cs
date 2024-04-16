using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class GoodsEntry : GameTableEntry, IGoodsTableEntry
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public GoodsEntry()
    {
    }

    /// <summary>
    /// The cost of the good
    /// </summary>
    public GoodsCost? Cost { get; set; }
}
