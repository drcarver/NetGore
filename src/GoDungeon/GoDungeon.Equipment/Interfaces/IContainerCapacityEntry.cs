using System.Collections.ObjectModel;

namespace GoDungeon.Equipment.Interfaces
{
    public interface IContainerCapacityEntry : IEquipmentTableEntry
    {
        /// <summary>
        /// The capacities of the container in various units
        /// </summary>
        ObservableCollection<ICapacity> Capacity { get; set; }
    }
}