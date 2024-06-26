//
// Adventuring Gear view model interface
//
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces;

public interface IWeight
{
    /// <summary>
    /// Weight of the item
    /// </summary>
    int Amount { get; set; }

    /// <summary>
    /// The units of weight (lb, o, etc.)
    /// </summary>
    WeightEnum Weight { get; set; }
}