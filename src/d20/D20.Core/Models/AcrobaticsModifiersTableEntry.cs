using D20.Core.Interfaces;

namespace D20.Core.Models
{
    public class AcrobaticsModifiersTableEntry : StandardTableEntry, IAcrobaticsModifiersTableEntry
    {
        /// <summary>
        /// The difficulty check modifier
        /// </summary>
        public int DifficultyCheckModifier { get; internal set; }
    }
}