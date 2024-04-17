using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class ContainerCapacityEntry : GameTableEntry, IContainerCapacityEntry
{
    /// <summary>
    /// Constructor
    /// </summary>
    [SetsRequiredMembers]
    public ContainerCapacityEntry()
    {
        ProperName = string.Empty;
        Description = string.Empty;
    }

    /// <summary>
    /// The capacities of the container in various units
    /// </summary>
    public List<Capacity> Capacity { get; set; } = [];

    /// <summary>
    /// The proper name of the container
    /// </summary>
    public string ProperName { get; set; }

    /// <summary>
    /// A description for the container
    /// </summary>
    public string Description { get; set; }
}