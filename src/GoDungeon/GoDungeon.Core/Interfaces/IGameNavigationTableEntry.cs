using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
{
    public interface IGameNavigationTableEntry : IStandardTableEntryViewModel
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