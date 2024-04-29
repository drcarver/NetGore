using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class PlatinumPieceVewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PlatinumPieceVewModel()
            : base("pp", Core.Enum.CoinEnum.Platinum)
        {
        }
    }
}
