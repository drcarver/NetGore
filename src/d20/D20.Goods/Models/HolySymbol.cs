using System.Diagnostics.CodeAnalysis;

using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class HolySymbol : GoodsTableEntry, IHolySymbol
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public HolySymbol()
    {
    }

    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }
}
