using D20.Character.Enum;
using D20.Core.Interfaces;

namespace D20.Character.Interfaces;

public interface IDeitiesTable : IGameTable
{
    /// <summary>
    /// Get deities by suggested class and alignment
    /// </summary>
    /// <param name="d20class">The suggested class</param>
    /// <param name="alignment">The alignment filter</param>
    /// <returns></returns>
    List<IDeityTableEntry> GetDeitiesByClass(ClassEnum d20class, AlignmentFilterEnum alignment);

}