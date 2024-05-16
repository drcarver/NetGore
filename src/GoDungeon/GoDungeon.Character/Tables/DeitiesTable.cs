using System.Collections.Generic;
using System.Linq;

using GoDungeon.Character.Interfaces;
using GoDungeon.Core.Enum;
using GoDungeon.Core.Tables;

namespace GoDungeon.Character.Tables
{
    public class DeitiesTable : NamedTable, IDeitiesTable
    {
        /// <summary>
        /// Get deities by suggested class and alignment
        /// </summary>
        /// <param name="characterClass">The suggested class</param>
        /// <param name="alignment">The alignment filter</param>
        /// <returns></returns>
        public List<IDeityTableEntry> GetDeitiesByClass(ClassEnum characterClass, AlignmentFilterEnum alignment)
        {
            var evilOnlyList = new List<AlignmentEnum>()
            {
                AlignmentEnum.LawfulEvil,
                AlignmentEnum.ChaoticEvil,
                AlignmentEnum.NeutralEvil,
            };

            var goodOrNeutralList = new List<AlignmentEnum>()
            {
                AlignmentEnum.LawfulGood,
                AlignmentEnum.NeutralGood,
                AlignmentEnum.ChaoticGood,
                AlignmentEnum.Neutral,
                AlignmentEnum.ChaoticNeutral,
            };

            var deityList = Table.Cast<IDeityTableEntry>()
                .Where(te => te.SuggestedClasses.Contains(characterClass))
                .ToList();

            switch (alignment)
            {
                case AlignmentFilterEnum.EvilOnly:
                    return deityList.Where(de =>
                        evilOnlyList.Contains(de.Alignment))
                        .ToList();
                case AlignmentFilterEnum.NonEvil:
                    return deityList.Where(de =>
                        goodOrNeutralList.Contains(de.Alignment))
                        .ToList();
                case AlignmentFilterEnum.Any:
                default:
                    return deityList;
            }
        }
    }
}
