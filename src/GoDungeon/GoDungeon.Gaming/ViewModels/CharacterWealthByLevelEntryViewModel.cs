using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Gaming.Interfaces;

namespace GoDungeon.Gaming.ViewModels
{
    public partial class CharacterWealthByLevelEntryViewModel : GameTableEntryViewModel, ICharacterWealthByLevelEntry
    {
        /// <summary>
        /// Character level
        /// </summary>
        [ObservableProperty]
        private int level;

        /// <summary>
        /// Wealth in gold pieces
        /// </summary>
        [ObservableProperty]
        private int wealth;
    }
}
