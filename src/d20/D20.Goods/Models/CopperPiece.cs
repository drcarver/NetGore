using System.Diagnostics.CodeAnalysis;

namespace D20.Goods.Models;

public class CopperPiece : Coin
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public CopperPiece()
        : base("Copper", "cp", Enum.CoinEnum.Copper)
    {
    }
}
