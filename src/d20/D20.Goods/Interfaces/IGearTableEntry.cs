namespace D20.Goods.Interfaces;

public interface IGearTableEntry : IGoodsTableEntry
{
    /// <summary>
    /// The weight of the gear
    /// </summary>
    decimal Weight { get; set; }
}