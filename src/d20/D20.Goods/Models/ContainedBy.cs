using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Goods.Enum;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class ContainedBy : GoodsTableEntry, IContainedBy
{
    /// <summary>
    /// A good to be purchased
    /// </summary>
    [SetsRequiredMembers]
    public ContainedBy()
    {
    }

    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    /// The container for the gear
    /// </summary>
    public EquipmentEnum Container { get; set; }

    /// <summary>
    /// The equipment Category
    /// </summary>
    public EquipmentCategoryEnum EquipmentCategory { get; set; }

    /// <summary>
    /// The equipment name
    /// </summary>
    public EquipmentEnum Equipment { get; set; }
}
