using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.Interfaces
{
    public interface IContainedBy : IEquipmentTableEntry
    {
        /// <summary>
        /// The container for the gear
        /// </summary>
        EquipmentEnum Container { get; set; }
    }
}