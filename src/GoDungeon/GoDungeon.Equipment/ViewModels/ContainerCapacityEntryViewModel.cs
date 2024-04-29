using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class ContainerCapacityEntryViewModel : QuantityOfEquipmentTableEntryViewModel, IContainerCapacityEntry
    {
        /// <summary>
        /// The capacities of the container in various units
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<ICapacity> capacity = new ObservableCollection<ICapacity>();
    }
}