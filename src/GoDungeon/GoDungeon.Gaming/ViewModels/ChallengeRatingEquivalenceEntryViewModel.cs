using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Gaming.Interfaces;

namespace GoDungeon.Gaming.ViewModels
{
    public partial class ChallengeRatingEquivalenceEntryViewModel : GameTableEntryViewModel, IChallengeRatingEquivalenceEntry
    {
        /// <summary>
        /// The number of creatures
        /// </summary>
        [ObservableProperty]
        private int numberOfCreatures;

        /// <summary>
        /// Equivalent challenge rating
        /// </summary>
        [ObservableProperty]
        private int challengeRatingEquivalence;
    }
}