using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class PlatinumPieceVewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PlatinumPieceVewModel()
            : base("pp", Enum.CoinEnum.Platinum)
        {
        }
    }
}
