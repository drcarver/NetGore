using System.Diagnostics.CodeAnalysis;

using D20.Core.Models;
using D20.Goods.Enum;
using D20.Goods.Interfaces;

namespace D20.Goods.Models;

public class ContainerCapacityEntry : NamedTableEntry, IContainerCapacityEntry
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
    /// The equipment Category
    /// </summary>
    public EquipmentCategoryEnum EquipmentCategory { get; set; }

    /// <summary>
    /// The equipment name
    /// </summary>
    public EquipmentEnum Equipment { get; set; }

}