using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

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
