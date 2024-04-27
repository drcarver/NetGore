using CommunityToolkit.Mvvm.ComponentModel;

using GoDungeon.Core.ViewModels;
using GoDungeon.Equipment.Enum;
using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public partial class CoinViewModel : BaseObjectViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name">The name of the coin</param>
        /// <param name="abbreviation">The abbreviation</param>
        public CoinViewModel(string abbreviation, CoinEnum coin)
        {
            Name = nameof(coin);
            Abbreviation = abbreviation;
            CoinEnum = coin;
        }

        /// <summary>
        /// The coin enum
        /// </summary>
        [ObservableProperty]
        private CoinEnum coinEnum;

        /// <summary>
        /// The Abbreviation for the coin
        /// </summary>
        [ObservableProperty]
        private string abbreviation;
    }
}
