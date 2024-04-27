using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Gaming.Interfaces;

namespace GoDungeon.Gaming.ViewModels
{
    public partial class EncounterDesignEntryViewModel : NamedTableEntryViewModel, IEncounterDesignEntry
    {
        /// <summary>
        /// Challenge Rating Equals
        /// </summary>
        [ObservableProperty]
        private int challengeRatingEquals;
    }
}
