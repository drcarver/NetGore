using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces
{
    public interface IByLength : IEquipmentTableEntry
    {
        /// <summary>
        /// The Length of the object
        /// </summary>
        IHeight? Length { get; set; }
    }
}