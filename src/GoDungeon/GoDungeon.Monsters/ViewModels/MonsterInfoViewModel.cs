using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.ViewModels;
using GoDungeon.Monsters.Interfaces;

namespace GoDungeon.Monsters.ViewModels
{
    public partial class MonsterInfoViewModel : StandardTableEntryViewModel, IMonsterInfo
    {
        /// <summary>
        /// The monster race
        /// </summary>
        [ObservableProperty]
        private RaceTypeEnum raceType;

        /// <summary>
        /// The monster Challenge rating
        /// </summary>
        [ObservableProperty]
        private decimal challengeRating;

        /// <summary>
        /// The terrain where the monster can be found
        /// </summary>
        [ObservableProperty]
        private TerrainEnum terrain;
    }
}
