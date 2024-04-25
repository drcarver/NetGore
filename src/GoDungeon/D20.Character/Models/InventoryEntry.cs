using D20.Character.Interfaces;
using D20.Goods.Enum;

namespace D20.Character.Models;

public class InventoryEntry : IInventoryEntry
{
    /// <summary>
    /// The quantity of this item in the inventory
    /// </summary>
    public int Quantity { get; set; }

    /// <summary>
    /// The equipment item
    /// </summary>
    public EquipmentEnum Equipment { get; set; }
}
