namespace D20.Goods.Models;

public class GoodsCost
{
    /// <summary>
    /// The cost of a good
    /// </summary>
    /// <param name="amount">The amount of coins</param>
    /// <param name="coin">The coins</param>
    public GoodsCost(int amount, Coin? coin)
    {
        Amount = amount;
        Coin = coin;
    }

    /// <summary>
    /// The amount of coins
    /// </summary>
    public int Amount { get; set; }

    /// <summary>
    /// The coins used for payment
    /// </summary>
    public Coin? Coin { get; set; }
}
