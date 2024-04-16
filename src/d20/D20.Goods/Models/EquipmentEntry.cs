using System.Diagnostics.CodeAnalysis;

using D20.Core.Enum;
using D20.Goods.Enum;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class EquipmentEntry : GoodsTableEntry, IEquipmentEntry
{
    /// <summary>
    /// The Equipment entry
    /// </summary>
    [SetsRequiredMembers]
    public EquipmentEntry()
    {
    }

    /// <summary>
    /// The equipment category (armor, weapons, etc.)
    /// </summary>
    public EquipmentCategoryEnum EquipmentCategory { get; set; }

    /// <summary>
    /// The equipment type
    /// </summary>
    public EquipmentEnum Equipment { get; set; }

    /// <summary>
    /// Weight in pounds  
    /// </summary>
    public decimal Weight { get; set; }
}
