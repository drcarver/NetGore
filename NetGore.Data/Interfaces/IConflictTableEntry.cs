using NetGore.Core.Interfaces;

namespace NetGore.Data.Interfaces;

public interface IConflictTableEntry : IGameTableEntry
{
    /// <summary>
    /// Conflict points
    /// </summary>
    int ConflictPoints { get; set; }
}