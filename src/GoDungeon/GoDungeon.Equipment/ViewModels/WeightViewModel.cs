//
// Equipment weight view model
//
using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels;

public partial class WeightViewModel : BaseObjectViewModel, IWeight
{
    /// <summary>
    /// Weight of the item
    /// </summary>
    [ObservableProperty]
    private int amount = 0;

    /// <summary>
    /// The units of weight (lb, oz, etc.)
    /// </summary>
    [ObservableProperty]
    private WeightEnum weight = WeightEnum.lb;

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
        if (Amount == 1)
        {
            return $"{Amount} {Weight.ToString()}s.";
        }
        return $"{Amount} {Weight.ToString()}s.";
    }

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="value">The value to be converted to a weight view model</param>
    public WeightViewModel(string value)
    {
        string[] weight = value.Split(' ');
        if (weight.Length == 2)
        {
            if (!int.TryParse(weight[0].ToLower().Trim(), out amount))
            {
                return;
            }
            switch (weight[1].ToLower().Trim())
            {
                case "oz.":
                    Weight = WeightEnum.ounce;
                    break;
                case "lb.":
                default:
                    Weight = WeightEnum.lb;
                    break;
            }
        }
    }
}