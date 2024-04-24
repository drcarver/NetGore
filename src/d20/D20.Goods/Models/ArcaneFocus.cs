using System.Diagnostics.CodeAnalysis;

using D20.Goods.Enum;
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

    /// <summary>
    /// The equipment Category
    /// </summary>
    public EquipmentCategoryEnum EquipmentCategory { get; set; }

    /// <summary>
    /// The equipment name
    /// </summary>
    public EquipmentEnum Equipment { get; set; }
}
