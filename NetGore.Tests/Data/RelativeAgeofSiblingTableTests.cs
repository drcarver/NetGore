using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class RelativeAgeofSiblingTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.RelativeAgeofSiblingTable.Name == "Relative Age of Sibling Table");
        ClassicAssert.IsTrue(BackgroundTables.RelativeAgeofSiblingTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.RelativeAgeofSiblingTable.DiceSides; i++)
        {
            var entry = BackgroundTables.RelativeAgeofSiblingTable.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, RandomTableEntry? entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //01–48	Your sibling is older than you.
            case int n when (n>= 1 && n <= 48):
                return entry.Name == nameof(RelativeAgeofSiblingEnum.Older);
            //49–96	Your sibling is younger than you.
            case int n when (n >= 49 && n <= 96):
                return entry.Name == nameof(RelativeAgeofSiblingEnum.Younger);
            //97–100	You and a sibling are twins(identical or fraternal, your choice). Roll on this table again. If you roll this result again, you are one of triplets; otherwise, your sibling’s relative age determines which of you emerged first.
            case int n when (n >= 97 && n <= 100):
                return entry.Name == nameof(RelativeAgeofSiblingEnum.Twins);
        }
        return false;
    }
}
