using NetGore.Core.Enum;
using NetGore.Data.Background;
using NetGore.Data.Models;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class AlignmentTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.AlignmentTable.Name == "Alignment Table");
        ClassicAssert.IsTrue(BackgroundTables.AlignmentTable.DiceSides == 9);

        for (int i = 1; i <= BackgroundTables.AlignmentTable.DiceSides; i++)
        {
            var entry = BackgroundTables.AlignmentTable.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, RandomTableRangeEntry? entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //1	Lawful Good
            case int n when (n>= 1 && n <= 1):
                return entry.Name == nameof(AlignmentEnum.LawfulGood)
                    && entry.Traits.Count == 0;

            //2	Neutral Good
            case int n when (n >= 2 && n <= 2):
                return entry.Name == nameof(AlignmentEnum.NeutralGood)
                    && entry.Traits.Count == 0;

            //3	Chaotic Good
            case int n when (n >= 3 && n <= 3):
                return entry.Name == nameof(AlignmentEnum.ChaoticGood)
                    && entry.Traits.Count == 0;

            //4	Lawful Neutral
            case int n when (n >= 4 && n <= 4):
                return entry.Name == nameof(AlignmentEnum.LawfulNeutral)
                    && entry.Traits.Count == 0;

            //5	Neutral
            case int n when (n >= 5 && n <= 5):
                return entry.Name == nameof(AlignmentEnum.Neutral)
                    && entry.Traits.Count == 0;

            //6	Chaotic Neutral
            case int n when (n >= 6 && n <= 6):
                return entry.Name == nameof(AlignmentEnum.ChaoticNeutral)
                    && entry.Traits.Count == 0;

            //7	Lawful Evil
            case int n when (n >= 7 && n <= 7):
                return entry.Name == nameof(AlignmentEnum.LawfulEvil)
                    && entry.Traits.Count == 0;

            //8	Neutral Evil
            case int n when (n >= 8 && n <= 8):
                return entry.Name == nameof(AlignmentEnum.NeutralEvil)
                    && entry.Traits.Count == 0;

            //9	Lawful Evil
            case int n when (n >= 9 && n <= 9):
                return entry.Name == nameof(AlignmentEnum.ChaoticEvil)
                    && entry.Traits.Count == 0;
        }
        return false;
    }
}

