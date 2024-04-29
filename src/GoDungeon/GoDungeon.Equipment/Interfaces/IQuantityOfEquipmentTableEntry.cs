using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces
{
    public interface IQuantityOfEquipmentTableEntry : IEquipmentTableEntry
    {
        /// <summary>
        /// The quantity of the ammunition
        /// </summary>
        decimal Quantity { get; set; }
    }
}
