using System.Diagnostics.CodeAnalysis;

namespace D20.Goods.Models;

public class GoldPiece : Coin
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public GoldPiece()
        : base("gp", Enum.CoinEnum.Gold)
    {
    }
}
