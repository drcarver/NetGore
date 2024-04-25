using System.Diagnostics.CodeAnalysis;

using D20.Core.Base;
using D20.Goods.Enum;

namespace D20.Goods.Models;

public class Coin : BaseObject
{
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">The name of the coin</param>
    /// <param name="abbreviation">The abbreviation</param>
    [SetsRequiredMembers]
    public Coin(string abbreviation, CoinEnum coin)
    {
        Name = nameof(coin);
        Abbreviation = abbreviation;
        CoinEnum = coin;
    }

    /// <summary>
    /// The coin enum
    /// </summary>
    public CoinEnum CoinEnum { get; set; }
    
    /// <summary>
    /// The Abbreviation for the coin
    /// </summary>
    public string Abbreviation { get; set; }
}
