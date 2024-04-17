namespace D20.Goods.Interfaces;

public interface IBagOf
{
    /// <summary>
    /// The weight of the gear
    /// </summary>
    decimal Weight { get; set; }

    /// <summary>
    /// The quantity of the BagOf
    /// </summary>
    int Quantity { get; set; }
}