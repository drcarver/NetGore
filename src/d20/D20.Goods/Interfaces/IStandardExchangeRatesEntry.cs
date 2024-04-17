// Ignore Spelling: Electrum
using D20.Core.Interfaces;
using D20.Goods.Models;

namespace D20.Goods.Interfaces;

public interface IStandardExchangeRatesEntry : IGameTableEntry
{
    /// <summary>
    /// The coin (cp, sp, ep, gp, pp)
    /// </summary>
    Coin? Coin { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in copper pieces
    /// </summary>
    decimal CopperRate { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in silver pieces
    /// </summary>
    decimal SilverRate { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in electrum pieces
    /// </summary>
    decimal ElectrumRate { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in gold pieces
    /// </summary>
    decimal GoldRate { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in platinum pieces
    /// </summary>
    decimal PlatinumRate { get; set; }

}