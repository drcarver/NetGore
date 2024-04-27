using System.Collections.Generic;
using System.Collections.ObjectModel;

using GoDungeon.Core.Interfaces;

namespace GoDungeon.Gaming.Interfaces
{
    public interface IGemStoneEntry : IGameTableEntry
    {
        /// <summary>
        /// The vale of the stone in gold pieces
        /// </summary>
        int Value { get; set; }

        /// <summary>
        /// The list of gem stones at this value
        /// </summary>
        ObservableCollection<string>? GemStones { get; set; }
    }
}