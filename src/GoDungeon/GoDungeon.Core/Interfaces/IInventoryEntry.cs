using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
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