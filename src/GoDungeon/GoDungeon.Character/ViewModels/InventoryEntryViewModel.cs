using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Character.Interfaces;
using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Character.ViewModels
{
    public partial class InventoryEntryViewModel : GameTableEntryViewModel, IInventoryEntry
    {
        /// <summary>
        /// The quantity of this item in the inventory
        /// </summary>
        [ObservableProperty]
        private int quantity;

        /// <summary>
        /// The equipment item
        /// </summary>
        [ObservableProperty]
        private EquipmentEnum equipment;
    }
}
