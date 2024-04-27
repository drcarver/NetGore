using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class CapacityViewModel : QuantityOfEquipmentTableEntryViewModel, ICapacity
    {
        /// <summary>
        /// The capacity unit type enum
        /// </summary>
        [ObservableProperty]
        private CapacityUnitTypeEnum capacityUnitType;
    }
}