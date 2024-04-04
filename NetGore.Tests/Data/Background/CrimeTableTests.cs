using NetGore.Core.Enum;
using NetGore.Core.Interfaces;
using NetGore.Data.Background;
using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Background;

[TestFixture]
public class CrimeTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var table = new CrimeTable();
        ClassicAssert.IsTrue(table.Name == nameof(CrimeTable));
        ClassicAssert.IsTrue(table.DiceSides == 100);

        for (int i = 1; i <= table.DiceSides; i++)
        {
            var entry = table.GetEntryByNumber(i);
            try
            {
                ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry {i} - Name = {entry?.Name} is incorrect");
            }
            catch (Exception e)
            {
                throw new ArgumentOutOfRangeException($"Index={i}");
            }
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
            //01–10	Adultery
            case int n when n >= 1 && n <= 10:
                return entry.Name == nameof(CrimeEnum.Adultery);

            //11–20	Arson
            case int n when n >= 11 && n <= 20:
                return entry.Name == nameof(CrimeEnum.Arson);

            //21–30	Burglary
            case int n when n >= 21 && n <= 30:
                return entry.Name == nameof(CrimeEnum.Burglary);

            //31–40	Heresy
            case int n when n >= 31 && n <= 40:
                return entry.Name == nameof(CrimeEnum.Heresy);

            //41–50	Minor offense(sumptuary law)
            case int n when n >= 41 && n <= 50:
                return entry.Name == nameof(CrimeEnum.Minoroffense);

            //51–60	Murder
            case int n when n >= 51 && n <= 60:
                return entry.Name == nameof(CrimeEnum.Murder);

            //61–70	Rebellion/treason
            case int n when n >= 61 && n <= 70:
                return entry.Name == nameof(CrimeEnum.RebellionorTreason);

            //71–80	Robbery
            case int n when n >= 71 && n <= 80:
                return entry.Name == nameof(CrimeEnum.Robbery);

            //81–90	Smuggling
            case int n when n >= 81 && n <= 90:
                return entry.Name == nameof(CrimeEnum.Smuggling);

            //91–100	Unlawful use of magic
            case int n when n >= 91 && n <= 100:
                return entry.Name == nameof(CrimeEnum.Unlawfuluseofmagic);
        }
        return false;
    }
}