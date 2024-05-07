using System;

using GoDungeon.Core.Enum;

namespace GoDungeon.Core.Interfaces
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

        /// <summary>
        /// The page detail type
        /// </summary>
        Type? PageDetailType { get; set; }
    }
}