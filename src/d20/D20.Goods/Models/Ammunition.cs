using System.Diagnostics.CodeAnalysis;

using D20.Goods.Enum;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class Ammunition : GoodsTableEntry, IAmmunition
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public Ammunition()
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

    /// <summary>
    /// The equipment Category
    /// </summary>
    public EquipmentCategoryEnum EquipmentCategory { get; set; }

    /// <summary>
    /// The equipment name
    /// </summary>
    public EquipmentEnum Equipment { get; set; }
}
