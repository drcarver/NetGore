using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class QuantityOfEquipmentTableEntryViewModel : EquipmentTableEntryViewModel, IQuantityOfEquipmentTableEntry
    {
        /// <summary>
        /// The quantity of the ammunition
        /// </summary>
        [ObservableProperty]
        private decimal quantity;
    }
}
