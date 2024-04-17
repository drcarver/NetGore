namespace D20.Goods.Interfaces;

public interface IDruidicFocus : IGoodsTableEntry
{
    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }
}