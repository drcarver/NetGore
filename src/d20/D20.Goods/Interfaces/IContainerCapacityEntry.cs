using D20.Goods.Models;

namespace D20.Goods.Interfaces;

public interface IContainerCapacityEntry
{
    /// <summary>
    /// The capacities of the container in various units
    /// </summary>
    List<Capacity> Capacity { get; set; }

    /// <summary>
    /// The proper name of the container
    /// </summary>
    string ProperName { get; set; }

    /// <summary>
    /// A description for the container
    /// </summary>
    string Description { get; set; }
}