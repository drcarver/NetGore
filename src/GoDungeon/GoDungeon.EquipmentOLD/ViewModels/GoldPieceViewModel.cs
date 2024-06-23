using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class GoldPieceViewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GoldPieceViewModel()
            : base("gp", Core.Enum.CoinEnum.Gold)
        {
        }
    }
}
