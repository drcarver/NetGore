using D20.Core.Interfaces;
using D20.Goods.Enum;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class Capacity : ICapacity
{
    /// <summary>
    /// The capacity unit type enum
    /// </summary>
    public CapacityUnitTypeEnum CapacityUnitType { get; set; }

    /// <summary>
    /// A description of the container
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// The quantity
    /// </summary>
    public decimal Quantity { get; set; }
}