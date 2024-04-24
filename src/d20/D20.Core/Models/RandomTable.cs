using System.Linq;
using System.Security.Cryptography;

using D20.Core.Interfaces;

namespace D20.Core.Models
{
    /// <summary>
    /// The random table is used for those tables
    /// where a entry is selected based on a roll
    /// of the dice.  Each entry has a range of dice
    /// values (e.g. 1..5 on a 20 sided dice).
    /// </summary>
    public class RandomTable : NamedTable, IRandomTable
    {
        /// <summary>
        /// The sides to a dice to be rolled to get random
        /// entries from the table
        /// </summary>
        public int DiceSides { get; set; }

        /// <summary>
        /// Get a entry from the table based on a random 
        /// dice roll
        /// </summary>
        /// <returns>The selected TableEntry.</returns>
        public virtual IRandomTableEntry GetRandomRangeEntry(int dice = 0)
        {
            int diceSides  = dice > 0 ? dice : DiceSides;
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                return GetRangeEntryByNumber(RandomNumberGenerator.GetInt32(diceSides) + 1);
            }
        }

        /// <summary>
        /// Get a entry from the table by it's number within
        /// a range
        /// </summary>
        /// <returns>The selected RandomTableEntry.</returns>
        public IRandomTableEntry GetRangeEntryByNumber(int number)
        {
            var te = Table.Cast<IRandomTableEntry>()
                .First(t =>
                    t.Range.Start.Value <= number
                        && t.Range.End.Value >= number);
            return te;
        }
    }
}
