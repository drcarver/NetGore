using D20.Core.Interfaces;

namespace D20.Background.Interfaces
{
    public interface IConflictTableEntry : IStandardTableEntry
    {
        /// <summary>
        /// Conflict points
        /// </summary>
        int ConflictPoints { get; set; }
    }
}