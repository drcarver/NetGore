using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public interface IGearTableEntry : IGoodsTableEntry
{
    /// <summary>
    /// The weight of the gear
    /// </summary>
    decimal Weight { get; set; }
}