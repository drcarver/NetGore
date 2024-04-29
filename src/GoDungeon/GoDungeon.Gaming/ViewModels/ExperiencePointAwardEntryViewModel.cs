using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Gaming.Interfaces;

namespace GoDungeon.Gaming.ViewModels
{
    public partial class ExperiencePointAwardEntryViewModel : GameTableEntryViewModel, IExperiencePointAwardEntry
    {
        /// <summary>
        /// Challenge Rating
        /// </summary>
        [ObservableProperty]
        private decimal challengeRating;

        /// <summary>
        /// Total XP
        /// </summary>
        [ObservableProperty]
        private int totalXP;

        /// <summary>
        /// Individual XP for a party of 1-3 characters
        /// </summary>
        [ObservableProperty]
        private int individual1to3XP;

        /// <summary>
        /// Individual XP for a party of 4-5 characters
        /// </summary>
        [ObservableProperty]
        private int individual4to5XP;

        /// <summary>
        /// Individual XP for a party of 6+ characters
        /// </summary>
        [ObservableProperty]
        private int individual6PlusXP;
    }
}
