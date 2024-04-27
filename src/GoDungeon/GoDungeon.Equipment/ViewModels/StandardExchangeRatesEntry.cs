// Ignore Spelling: Electrum

using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class StandardExchangeRatesEntryViewModel : NamedTableEntryViewModel, IStandardExchangeRatesEntry
    {
        /// <summary>
        /// The coin (cp, sp, ep, gp, pp)
        /// </summary>
        [ObservableProperty]
        private ICoin? coin;

        /// <summary>
        /// The equivalent amount of the coin in copper pieces
        /// </summary>
        [ObservableProperty]
        private decimal copperRate;

        /// <summary>
        /// The equivalent amount of the coin in silver pieces
        /// </summary>
        [ObservableProperty]
        private decimal silverRate;

        /// <summary>
        /// The equivalent amount of the coin in electrum pieces
        /// </summary>
        [ObservableProperty]
        private decimal electrumRate;

        /// <summary>
        /// The equivalent amount of the coin in gold pieces
        /// </summary>
        [ObservableProperty]
        private decimal goldRate;

        /// <summary>
        /// The equivalent amount of the coin in platinum pieces
        /// </summary>
        [ObservableProperty]
        private decimal platinumRate;
    }
}