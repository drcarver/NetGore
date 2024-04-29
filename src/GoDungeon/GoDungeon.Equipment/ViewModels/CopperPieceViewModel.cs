using GoDungeon.Core.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class CopperPieceViewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CopperPieceViewModel()
            : base("cp", Core.Enum.CoinEnum.Copper)
        {
        }
    }
}
