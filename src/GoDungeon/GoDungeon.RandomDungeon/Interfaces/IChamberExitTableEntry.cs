using GoDungeon.Core.Interfaces;

namespace GoDungeon.RandomDungeon.Interfaces
{
    public interface IChamberExitTableEntry : IRandomTableEntry
    {
        /// <summary>
        /// The number of exits from a large chamber
        /// </summary>
        public int? LargeChamber { get; set; }

        /// <summary>
        /// The number of exits from a small chamber
        /// </summary>
        public int? NormalChamber { get; set; }

    }
}