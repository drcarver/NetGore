using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class GearTableEntry : GoodsTableEntry, IGearTableEntry
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public GearTableEntry()
    {
    }

    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }
}
