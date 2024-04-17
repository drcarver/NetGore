using System.Diagnostics.CodeAnalysis;

namespace D20.Goods.Models;

public class ElectrumPiece : Coin
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ElectrumPiece()
        : base("ep", Enum.CoinEnum.Electrum)
    {
    }
}
