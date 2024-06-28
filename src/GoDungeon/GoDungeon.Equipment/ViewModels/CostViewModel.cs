using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

public partial class CostViewModel : ObservableObject, ICost
{
    /// <summary>
    /// The type of Coin
    /// </summary>
    [ObservableProperty]
    private CoinTypeEnum? coin = CoinTypeEnum.Gold;

    /// <summary>
    /// The amount of coins
    /// </summary>
    [ObservableProperty]
    private decimal amount = 0;

    /// <summary>
    /// Override to convert to a string
    /// </summary>
    /// <returns>The weight as a string</returns>
    public override string ToString()
    {
        if (Amount == 0)
        {
            return string.Empty;
        }
        if (Amount > 1)
        {
            return $"{Amount} {Coin.ToString()} Piece";
        }
        return $"{Amount} {Coin.ToString()} Pieces";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="value">The value to be converted to a cost view model</param>
    public CostViewModel(string  value)
    {
        string[] cost = value.Split(' ');
        if (cost.Length == 2)
        {
            if (!decimal.TryParse(cost[0].ToLower().Trim(), out amount))
            {
                return;
            }
            switch (cost[1].ToLower().Trim())
            {
                case "cp":
                    Coin = CoinTypeEnum.Copper;
                    break;
                case "sp":
                    Coin = CoinTypeEnum.Silver;
                    break;
                case "ep":
                    Coin = CoinTypeEnum.Electrum;
                    break;
                case "pp":
                    Coin = CoinTypeEnum.Platinum;
                    break;
                case "gp":
                default:
                    Coin = CoinTypeEnum.Gold;
                    break;
            }
        }
    }
}