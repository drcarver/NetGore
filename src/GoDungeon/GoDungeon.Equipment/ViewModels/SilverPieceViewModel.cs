using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class SilverPieceViewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public SilverPieceViewModel()
            : base("sp", Enum.CoinEnum.Silver)
        {
        }
    }
}
