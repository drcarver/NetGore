using GoDungeon.Core.Interfaces;
using GoDungeon.Equipment.Enum;

namespace GoDungeon.Equipment.Interfaces
{
    public interface ICoin : IBaseObject
    {
        /// <summary>
        /// The coin enum
        /// </summary>
        public CoinEnum CoinEnum { get; set; }

        /// <summary>
        /// The Abbreviation for the coin
        /// </summary>
        public string Abbreviation { get; set; }
    }
}