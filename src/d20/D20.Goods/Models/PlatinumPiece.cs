using System.Diagnostics.CodeAnalysis;

namespace D20.Goods.Models;

public class PlatinumPiece : Coin
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public PlatinumPiece()
        : base("Platinum", "pp", Enum.CoinEnum.Platinum)
    {
    }
}
