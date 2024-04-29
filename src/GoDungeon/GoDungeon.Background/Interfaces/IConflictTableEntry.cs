using GoDungeon.Core.Interfaces;

namespace GoDungeon.Background.Interfaces
{
    public interface IConflictTableEntryViewModel : IStandardTableEntry
    {
        /// <summary>
        /// Conflict points
        /// </summary>
        int ConflictPoints { get; set; }
    }
}