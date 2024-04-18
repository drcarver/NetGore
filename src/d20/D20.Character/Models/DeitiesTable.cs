using System.Diagnostics.CodeAnalysis;

using D20.Character.Enum;
using D20.Character.Interfaces;
using D20.Core.Enum;
using D20.Core.Models;

namespace D20.Character.Models;

public class DeitiesTable : NamedTable, IDeitiesTable
{
    /// <summary>
    /// The deities for a particular pantheon
    /// </summary>
    [SetsRequiredMembers]
    public DeitiesTable()
    {
    }

    /// <summary>
    /// Get deities by suggested class and alignment
    /// </summary>
    /// <param name="d20class">The suggested class</param>
    /// <param name="alignment">The alignment filter</param>
    /// <returns></returns>
    public List<IDeityTableEntry> GetDeitiesByClass(ClassEnum d20class, AlignmentFilterEnum alignment)
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
            .Where(te => te.SuggestedClasses.Contains(d20class))
            .ToList();

        switch (alignment)
        {
            case AlignmentFilterEnum.EvilOnly:
                return deityList.Where(de =>
                    evilOnlyList.Contains(de.Alignment))
                    .ToList();
            case AlignmentFilterEnum.GoodOrNeutral:
                return deityList.Where(de =>
                    goodOrNeutralList.Contains(de.Alignment))
                    .ToList();
            case AlignmentFilterEnum.Any:
            default:
                return deityList;
        }
    }
}
