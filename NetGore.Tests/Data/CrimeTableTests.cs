using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class CrimeTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.CrimeTable.Name == "CrimeTable");
        ClassicAssert.IsTrue(BackgroundTables.CrimeTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.CrimeTable.DiceSides; i++)
        {
            var entry = BackgroundTables.CrimeTable.GetEntryByNumber(i);
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
            //01–10	Adultery
            case int n when (n>= 1 && n <= 10):
                return entry.Name == nameof(CrimeEnum.Adultery)
                    && entry.Traits.Count == 0;

            //11–20	Arson
            case int n when (n >= 11 && n <= 20):
                return entry.Name == nameof(CrimeEnum.Arson)
                    && entry.Traits.Count == 0;

            //21–30	Burglary
            case int n when (n >= 21 && n <= 30):
                return entry.Name == nameof(CrimeEnum.Burglary)
                    && entry.Traits.Count == 0;

            //31–40	Heresy
            case int n when (n >= 31 && n <= 40):
                return entry.Name == nameof(CrimeEnum.Heresy)
                    && entry.Traits.Count == 0;

            //41–50	Minor offense(sumptuary law)
            case int n when (n >= 41 && n <= 50):
                return entry.Name == nameof(CrimeEnum.Minoroffense)
                    && entry.Traits.Count == 0;

            //51–60	Murder
            case int n when (n >= 51 && n <= 60):
                return entry.Name == nameof(CrimeEnum.Murder)
                    && entry.Traits.Count == 0;

            //61–70	Rebellion/treason
            case int n when (n >= 61 && n <= 70):
                return entry.Name == nameof(CrimeEnum.RebellionorTreason)
                    && entry.Traits.Count == 0;

            //71–80	Robbery
            case int n when (n >= 71 && n <= 80):
                return entry.Name == nameof(CrimeEnum.Robbery)
                    && entry.Traits.Count == 0;

            //81–90	Smuggling
            case int n when (n >= 81 && n <= 90):
                return entry.Name == nameof(CrimeEnum.Smuggling)
                    && entry.Traits.Count == 0;

            //91–100	Unlawful use of magic
            case int n when (n >= 91 && n <= 100):
                return entry.Name == nameof(CrimeEnum.Unlawfuluseofmagic)
                    && entry.Traits.Count == 0;

        }
        return false;
    }
}