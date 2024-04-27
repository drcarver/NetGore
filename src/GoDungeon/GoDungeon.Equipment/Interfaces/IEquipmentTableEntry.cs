using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces
{
    public interface IEquipmentTableEntry : IStandardTableEntry
    {
        /// <summary>
        /// The weight of the equipment
        /// </summary>
        decimal Weight { get; set; }

        /// <summary>
        /// The equipment type
        /// </summary>
        EquipmentCategoryEnum EquipmentCategory { get; set; }

        /// <summary>
        /// The equipment type
        /// </summary>
        EquipmentEnum Equipment { get; set; }

        /// <summary>
        /// The goods cost
        /// </summary>
        IEquipmentCost? Cost { get; set; }
    }
}