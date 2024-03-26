using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class NobilityTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.NobilityTable.Name == "NobilityTable");
        ClassicAssert.IsTrue(BackgroundTables.NobilityTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.NobilityTable.DiceSides; i++)
        {
            var entry = BackgroundTables.NobilityTable.GetEntryByNumber(i);
            ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
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
            //01–60	Gentry
            case int n when (n>= 1 && n <= 60):
                return entry.Name == nameof(NobilityEnum.Gentry)
                    && entry.Traits.Count == 0;

            //61–78	Knight
            case int n when (n >= 61 && n <= 78):
                return entry.Name == nameof(NobilityEnum.Knight)
                    && entry.Traits.Count == 0;

            //79–85	Baron
            case int n when (n >= 79 && n <= 85):
                return entry.Name == nameof(NobilityEnum.Baron)
                    && entry.Traits.Count == 0;

            //86–91	Count
            case int n when (n >= 86 && n <= 91):
                return entry.Name == nameof(NobilityEnum.Count)
                    && entry.Traits.Count == 0;

            //92–96	Duke
            case int n when (n >= 92 && n <= 96):
                return entry.Name == nameof(NobilityEnum.Duke)
                    && entry.Traits.Count == 0;

            //97–99	Minor Prince
            case int n when (n >= 97 && n <= 99):
                return entry.Name == nameof(NobilityEnum.MinorPrince)
                    && entry.Traits.Count == 0;

            //100	Regent
            case int n when (n >= 100 && n <= 100):
                return entry.Name == nameof(NobilityEnum.Regent)
                    && entry.Traits.Count == 0;
        }
        return false;
    }
}
