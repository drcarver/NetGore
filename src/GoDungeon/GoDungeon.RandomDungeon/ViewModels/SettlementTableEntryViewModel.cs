using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.RandomDungeon.Interfaces;

namespace GoDungeon.RandomDungeon.ViewModels
{
    public partial class SettlementTableEntryViewModel :  RandomTableEntryViewModel, ISettlement
    {
        /// <summary>
        /// THe population of the city
        /// </summary>
        [ObservableProperty]
        private string? population;

        /// <summary>
        /// The type of government
        /// </summary>
        [ObservableProperty]
        private string? government;

        /// <summary>
        /// The type of defense the settlement has
        /// </summary>
        [ObservableProperty]
        private string? defense;

        /// <summary>
        /// The types of commerce of for the settlement
        /// </summary>
        [ObservableProperty]
        private string? commerce;

        /// <summary>
        /// The organizations in the city
        /// </summary>
        [ObservableProperty]
        private string? organizations;
    }
}