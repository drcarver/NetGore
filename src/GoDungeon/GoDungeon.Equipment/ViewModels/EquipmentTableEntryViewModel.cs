using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class EquipmentTableEntryViewModel : StandardTableEntryViewModel, IEquipmentTableEntry
    {
        /// <summary>
        /// The equipment type
        /// </summary>
        [ObservableProperty]
        private EquipmentCategoryEnum equipmentCategory;

        /// <summary>
        /// The equipment type
        /// </summary>
        [ObservableProperty]
        private EquipmentEnum equipment;

        /// <summary>
        /// The cost of the good
        /// </summary>
        [ObservableProperty]
        private IEquipmentCost? cost;

        /// <summary>
        /// The weight of the equipment
        /// </summary>
        [ObservableProperty]
        private decimal weight;
    }
}
