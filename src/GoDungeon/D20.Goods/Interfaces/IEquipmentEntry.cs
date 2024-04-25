using D20.Goods.Enum;

namespace D20.Goods.Interfaces;

public interface IEquipmentEntry : IGoodsTableEntry
{
    /// <summary>
    /// The weight of the goods
    /// </summary>
    decimal Weight { get; set; }
}