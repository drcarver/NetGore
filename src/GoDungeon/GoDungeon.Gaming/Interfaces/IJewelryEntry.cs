using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;
using GoDungeon.Gaming.Enum;

namespace GoDungeon.Gaming.Interfaces
{
    public interface IJewelryEntry : IGameTableEntry
    {
        /// <summary>
        /// The type of treasure
        /// </summary>
        TreasureTypeEnum TreasureType { get; set; }

        /// <summary>
        /// The value of the stone in gold pieces
        /// </summary>
        int Value { get; set; }

        /// <summary>
        /// The list of jewelry at this value
        /// </summary>
        ObservableCollection<string> Jewelry { get; set; }
    }
}