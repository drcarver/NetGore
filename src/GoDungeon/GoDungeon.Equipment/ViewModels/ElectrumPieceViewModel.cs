using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class ElectrumPieceViewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ElectrumPieceViewModel()
            : base("ep", Core.Enum.CoinEnum.Electrum)
        {
        }
    }
}
