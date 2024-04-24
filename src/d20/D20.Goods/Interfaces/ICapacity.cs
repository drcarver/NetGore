using D20.Goods.Enum;

namespace D20.Goods.Interfaces;

public interface ICapacity
{
    /// <summary>
    /// The capacity unit type enum
    /// </summary>
    CapacityUnitTypeEnum CapacityUnitType { get; set; }

    /// <summary>
    /// A description of the container
    /// </summary>
    string? Description { get; set; }

    /// <summary>
    /// The quantity
    /// </summary>
    decimal Quantity { get; set; }
}