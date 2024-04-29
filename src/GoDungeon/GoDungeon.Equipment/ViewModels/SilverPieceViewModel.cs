using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class SilverPieceViewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SilverPieceViewModel()
            : base("sp", Core.Enum.CoinEnum.Silver)
        {
        }
    }
}
