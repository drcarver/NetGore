using System.Diagnostics.CodeAnalysis;

using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class ArcaneFocus : GoodsTableEntry, IArcaneFocus
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public ArcaneFocus()
    {
    }

    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }
}
