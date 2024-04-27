using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class GoldPieceViewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public GoldPieceViewModel()
            : base("gp", Enum.CoinEnum.Gold)
        {
        }
    }
}
