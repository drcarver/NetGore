using System.Collections.Generic;
using System.Collections.ObjectModel;

using GoDungeon.Core.Enum;
using GoDungeon.Core.Interfaces;

namespace GoDungeon.Character.Interfaces
{
    public interface IDeitiesTable : INamedTable
    {
        /// <summary>
        /// Get deities by suggested class and alignment
        /// </summary>
        /// <param name="characterclass">The suggested class</param>
        /// <param name="alignment">The alignment filter</param>
        /// <returns></returns>
        List<IDeityTableEntry> GetDeitiesByClass(ClassEnum characterClass, AlignmentFilterEnum alignment);
    }
}