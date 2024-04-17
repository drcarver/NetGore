namespace D20.Goods.Interfaces;

public interface IMiscellaneousItem : IGoodsTableEntry
{
    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }

    /// <summary>
    /// The quantity of the ammunition
    /// </summary>
    public int Quantity { get; set; }
}