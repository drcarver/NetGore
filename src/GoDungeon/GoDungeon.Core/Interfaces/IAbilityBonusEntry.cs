using System;

namespace GoDungeon.Core.Interfaces
{
    public interface IAbilityBonusEntry : IGameTableEntry
    {
        /// <summary>
        /// The range of a ability scores for this entry
        /// </summary>
        public Range Score { get; set; }

        /// <summary>
        /// The ability modifier
        /// </summary>
        public int Modifier { get; set; }
    }
}