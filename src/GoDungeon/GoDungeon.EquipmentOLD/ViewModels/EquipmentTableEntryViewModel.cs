using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;
using GoDungeon.Core.ViewModels;

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
        private int equipment;

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
