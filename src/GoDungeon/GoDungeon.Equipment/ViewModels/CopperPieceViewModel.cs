using GoDungeon.Equipment.Interfaces;

namespace GoDungeon.Equipment.ViewModels
{
    public class CopperPieceViewModel : CoinViewModel, ICoin
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public CopperPieceViewModel()
            : base("cp", Enum.CoinEnum.Copper)
        {
        }
    }
}
