using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Gaming.Interfaces;

namespace GoDungeon.Gaming.ViewModels
{
    /// <summary>
    /// The speed of the campaign’s XP progression (slow, medium, 
    /// or fast).
    /// </summary>
    public partial class TreasureValuesPerEncounterEntryViewModel : GameTableEntryViewModel, ITreasureValuesPerEncounterEntry
    {
        /// <summary>
        /// The challenge rating
        /// </summary>
        [ObservableProperty]
        private decimal challengeRating;

        /// <summary>
        /// The gold pieces awarded for encounter when playing
        /// a campaign with a slow XP progression
        /// </summary>
        [ObservableProperty]
        private int slow;

        /// <summary>
        /// The gold pieces awarded for encounter when playing
        /// a campaign with a medium XP progression
        /// </summary>
        [ObservableProperty]
        private int medium;

        /// <summary>
        /// The gold pieces awarded for encounter when playing
        /// a campaign with a fast XP progression
        /// </summary>
        [ObservableProperty]
        private int fast;
    }
}