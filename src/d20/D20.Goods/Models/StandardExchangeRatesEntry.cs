using System.Diagnostics.CodeAnalysis;

using D20.Core.Interfaces;
using D20.Core.Models;

namespace D20.Goods.Models;

public class StandardExchangeRatesEntry : GameTableEntry, IGameTableEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public StandardExchangeRatesEntry()
    {
    }

    /// <summary>
    /// The coin (cp, sp, ep, gp, pp)
    /// </summary>
    public Coin? Coin { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in copper pieces
    /// </summary>
    public decimal CopperRate { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in silver pieces
    /// </summary>
    public decimal SilverRate { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in electrum pieces
    /// </summary>
    public decimal ElectrumRate { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in gold pieces
    /// </summary>
    public decimal GoldRate { get; set; }

    /// <summary>
    /// The equivalent amount of the coin in platinum pieces
    /// </summary>
    public decimal PlatinumRate { get; set; }
}