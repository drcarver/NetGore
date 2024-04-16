using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class GoodsTableEntry : StandardTableEntry, IGoodsTableEntry
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public GoodsTableEntry()
    {
    }

    /// <summary>
    /// The cost of the good
    /// </summary>
    public GoodsCost? Cost { get; set; }
}
