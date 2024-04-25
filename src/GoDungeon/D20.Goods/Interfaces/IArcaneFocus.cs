namespace D20.Goods.Interfaces;

public interface IArcaneFocus : IGoodsTableEntry
{
    /// <summary>
    /// The weight of the gear
    /// </summary>
    public decimal Weight { get; set; }
}