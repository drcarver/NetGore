using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces
{
    public interface ICapacity : IQuantityOfEquipmentTableEntry
    {
        /// <summary>
        /// The capacity unit type enum
        /// </summary>
        CapacityUnitTypeEnum CapacityUnitType { get; set; }
    }
}