using D20.Core.Interfaces;
using D20.Goods.Enum;
using D20.Goods.Models;

namespace D20.Goods.Interfaces;

public interface IGoodsTableEntry : IStandardTableEntry
{
    /// <summary>
    /// The equipment type
    /// </summary>
    EquipmentCategoryEnum EquipmentCategory { get; set; }

    /// <summary>
    /// The equipment type
    /// </summary>
    EquipmentEnum Equipment { get; set; }

    /// <summary>
    /// The goods cost
    /// </summary>
    GoodsCost? Cost { get; set; }
}