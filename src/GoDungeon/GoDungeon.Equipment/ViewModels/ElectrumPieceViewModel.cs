using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class ElectrumPieceViewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public ElectrumPieceViewModel()
            : base("ep", Enum.CoinEnum.Electrum)
        {
        }
    }
}
