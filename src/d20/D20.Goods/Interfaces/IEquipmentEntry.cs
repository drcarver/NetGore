using D20.Goods.Enum;

namespace D20.Goods.Interfaces;

public interface IEquipmentEntry : IGoodsTableEntry
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
    /// The weight of the goods
    /// </summary>
    decimal Weight { get; set; }
}