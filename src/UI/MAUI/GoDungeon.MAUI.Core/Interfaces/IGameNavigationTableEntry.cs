using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.MAUI.Core.Interfaces
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