using D20.Core.Models;

namespace D20.Goods.Interfaces;

public interface IByLength
{
    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    /// The Length of the object
    /// </summary>
    public Height Length { get; set; }
}