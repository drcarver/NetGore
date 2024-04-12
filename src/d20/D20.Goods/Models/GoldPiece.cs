using System.Diagnostics.CodeAnalysis;

namespace D20.Goods.Models;

public class GoldPiece : Coin
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public GoldPiece()
        : base("Gold", "gp", Enum.CoinEnum.Gold)
    {
    }
}
