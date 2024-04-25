using D20.Background.Interfaces;
using D20.Core.Models;

namespace D20.Background.Models
{
    public class ConflictTableEntry : StandardTableEntry, IConflictTableEntry
    {
        /// <summary>
        /// Conflict points
        /// </summary>
        public int ConflictPoints { get; set; }
    }
}
