using D20.Core.Enum;

namespace D20.Core.Interfaces
{
    public interface IGameNavigationTableEntry : IStandardTableEntry
    {
        /// <summary>
        /// The table type
        /// </summary>
        TableTypeEnum TableType { get; set; }

        /// <summary>
        /// Route for the entry
        /// </summary>
        string? Route { get; set; }
    }
}