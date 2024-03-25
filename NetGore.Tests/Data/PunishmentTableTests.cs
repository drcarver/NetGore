using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class PunishmentTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.PunishmentTable.Name == "PunishmentTable");
        ClassicAssert.IsTrue(BackgroundTables.PunishmentTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.PunishmentTable.DiceSides; i++)
        {
            var entry = BackgroundTables.PunishmentTable.GetEntryByNumber(i);
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
            //01–10	Beating
            case int n when (n>= 1 && n <= 10):
                return entry.Name == nameof(PunishmentEnum.Beating)
                    && entry.Traits.Count == 0;

            //11–20	Branding
            case int n when (n >= 11 && n <= 20):
                return entry.Name == nameof(PunishmentEnum.Branding)
                    && entry.Traits.Count == 0;

            //21–30	Exile
            case int n when (n >= 21 && n <= 30):
                return entry.Name == nameof(PunishmentEnum.Exile)
                    && entry.Traits.Count == 0;

            //31–40	Fine
            case int n when (n >= 31 && n <= 40):
                return entry.Name == nameof(PunishmentEnum.Fine)
                    && entry.Traits.Count == 0;

            //41–50	Imprisonment
            case int n when (n >= 41 && n <= 50):
                return entry.Name == nameof(PunishmentEnum.Imprisonment)
                    && entry.Traits.Count == 0;

            //51–60	Stocks
            case int n when (n >= 51 && n <= 60):
                return entry.Name == nameof(PunishmentEnum.Stocks)
                    && entry.Traits.Count == 0;

            //61–70	Torture
            case int n when (n >= 61 && n <= 70):
                return entry.Name == nameof(PunishmentEnum.Torture)
                    && entry.Traits.Count == 0;

            //71–80	Trial by combat
            case int n when (n >= 71 && n <= 80):
                return entry.Name == nameof(PunishmentEnum.Trialbycombat)
                    && entry.Traits.Count == 0;

            //81–90	Trial by fire
            case int n when (n >= 81 && n <= 90):
                return entry.Name == nameof(PunishmentEnum.Trialbyfire)
                    && entry.Traits.Count == 0;

            //91–100	Trial by water
            case int n when (n >= 91 && n <= 100):
                return entry.Name == nameof(PunishmentEnum.Trialbywater)
                    && entry.Traits.Count == 0;

        }
        return false;
    }
}
