using System.Collections.ObjectModel;

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Gaming.Enum;
using GoDungeon.Gaming.Interfaces;

namespace GoDungeon.Gaming.ViewModels
{
    public partial class GemStoneEntryViewModel : BaseObjectViewModel, IGemStoneEntry
    {
        /// <summary>
        /// The type of treasure
        /// </summary>
        [ObservableProperty]
        private TreasureTypeEnum treasureType;

        /// <summary>
        /// The value of the stone in gold pieces
        /// </summary>
        [ObservableProperty]
        private int value;

        /// <summary>
        /// The list of gem stones at this value
        /// </summary>
        [ObservableProperty]
        private ObservableCollection<string>? gemStones;
    }
}