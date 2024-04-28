using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Character.Interfaces
{
    public interface IInventoryEntry : IGameTableEntry
    {
        /// <summary>
        /// The quantity of this item in the inventory
        /// </summary>
        int Quantity { get; set; }

        /// <summary>
        /// The equipment item
        /// </summary>
        EquipmentEnum Equipment { get; set; }
    }
}