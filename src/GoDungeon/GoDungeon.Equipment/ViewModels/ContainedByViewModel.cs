using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class ContainedByViewModel : EquipmentTableEntryViewModel, IContainedBy
    {
        /// <summary>
        /// The container for the gear
        /// </summary>
        [ObservableProperty]
        private EquipmentEnum container;
    }
}
