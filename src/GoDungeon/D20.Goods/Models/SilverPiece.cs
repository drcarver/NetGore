using System.Diagnostics.CodeAnalysis;

namespace D20.Goods.Models;

public class SilverPiece : Coin
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public SilverPiece()
        : base("sp", Enum.CoinEnum.Silver)
    {
    }
}
