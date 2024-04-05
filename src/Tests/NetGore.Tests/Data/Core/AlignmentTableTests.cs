using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Data.Core;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Core;

[TestFixture]
public class AlignmentTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var table = new AlignmentTable();
        ClassicAssert.IsTrue(table.Name == nameof(AlignmentTable));
        ClassicAssert.IsTrue(table.DiceSides == 9);

        for (int i = 1; i <= table.DiceSides; i++)
        {
            var entry = table.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, IGameTableEntry entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //1	Lawful Good
            case int n when n >= 1 && n <= 1:
                return entry.Name == nameof(AlignmentEnum.LawfulGood);

            //2	Neutral Good
            case int n when n >= 2 && n <= 2:
                return entry.Name == nameof(AlignmentEnum.NeutralGood);

            //3	Chaotic Good
            case int n when n >= 3 && n <= 3:
                return entry.Name == nameof(AlignmentEnum.ChaoticGood);

            //4	Lawful Neutral
            case int n when n >= 4 && n <= 4:
                return entry.Name == nameof(AlignmentEnum.LawfulNeutral);

            //5	Neutral
            case int n when n >= 5 && n <= 5:
                return entry.Name == nameof(AlignmentEnum.Neutral);

            //6	Chaotic Neutral
            case int n when n >= 6 && n <= 6:
                return entry.Name == nameof(AlignmentEnum.ChaoticNeutral);

            //7	Lawful Evil
            case int n when n >= 7 && n <= 7:
                return entry.Name == nameof(AlignmentEnum.LawfulEvil);

            //8	Neutral Evil
            case int n when n >= 8 && n <= 8:
                return entry.Name == nameof(AlignmentEnum.NeutralEvil);

            //9	Lawful Evil
            case int n when n >= 9 && n <= 9:
                return entry.Name == nameof(AlignmentEnum.ChaoticEvil);
        }
        return false;
    }
}

