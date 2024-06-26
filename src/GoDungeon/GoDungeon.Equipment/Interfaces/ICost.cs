using GoDungeon.Core.Enum;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces;

public interface ICost
{
    /// <summary>
    /// The type of Coin
    /// </summary>
    CoinType? Coin { get; set; }

    /// <summary>
    /// The amount of coins
    /// </summary>
    decimal Amount { get; set; }
}