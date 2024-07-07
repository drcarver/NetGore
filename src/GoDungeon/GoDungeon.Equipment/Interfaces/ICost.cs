using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces;

public interface ICost
{
    /// <summary>
    /// The type of Coin
    /// </summary>
    CoinTypeEnum? Coin { get; set; }

    /// <summary>
    /// The amount of coins
    /// </summary>
    decimal Amount { get; set; }

    /// <summary>
    /// The original string parsed
    /// </summary>
    string OriginalString { get; set; } 

}