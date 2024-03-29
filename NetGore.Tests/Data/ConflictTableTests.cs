using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class ConflictTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.ConflictTable.Name == "The Conflicts Table");
        ClassicAssert.IsTrue(BackgroundTables.ConflictTable.DiceSides == 20);

        for (int i = 1; i <= BackgroundTables.ConflictTable.DiceSides; i++)
        {
            var entry = BackgroundTables.ConflictTable.GetEntryByNumber(i);
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
            //1	Minor Failure
            case int n when (n>= 1 && n <= 1):
                return entry.Name == nameof(ConflictEnum.MinorFailure)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 1;

            //2	Petty Crime
            case int n when (n >= 2 && n <= 2):
                return entry.Name == nameof(ConflictEnum.PettyCrime)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 1;

            //2	Petty Crime
            case int n when (n >= 2 && n <= 2):
                return entry.Name == nameof(ConflictEnum.PettyCrime)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 1;

            //3	Told a Lie
            case int n when (n >= 3 && n <= 3):
                return entry.Name == nameof(ConflictEnum.ToldaLie)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 1;

            //4	Broke a Promise
            case int n when (n >= 4 && n <= 4):
                return entry.Name == nameof(ConflictEnum.BrokeaPromise)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 1;

            //5	Humiliation
            case int n when (n >= 5 && n <= 5):
                return entry.Name == nameof(ConflictEnum.Humiliation)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 2;

            //6	Negligence
            case int n when (n >= 6 && n <= 6):
                return entry.Name == nameof(ConflictEnum.Negligence)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 2;

            //6	Negligence
            case int n when (n >= 6 && n <= 6):
                return entry.Name == nameof(ConflictEnum.Negligence)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 2;

            //7	Minor Theft
            case int n when (n >= 7 && n <= 7):
                return entry.Name == nameof(ConflictEnum.MinorTheft)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 2;

            //8	Seducer
            case int n when (n >= 8 && n <= 8):
                return entry.Name == nameof(ConflictEnum.Seducer)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 3;

            //9	Cheater
            case int n when (n >= 9 && n <= 9):
                return entry.Name == nameof(ConflictEnum.Cheater)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 3;

            //10 Betrayal
            case int n when (n >= 10 && n <= 10):
                return entry.Name == nameof(ConflictEnum.Betrayal)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 4;

            //11	Malign Associates
            case int n when (n >= 11 && n <= 11):
                return entry.Name == nameof(ConflictEnum.MalignAssociates)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 4;

            //12 Destroyed a Reputation
            case int n when (n >= 12 && n <= 12):
                return entry.Name == nameof(ConflictEnum.DestroyedaReputation)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 5;

            //13 Major Theft
            case int n when (n >= 13 && n <= 13):
                return entry.Name == nameof(ConflictEnum.MajorTheft)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 5;

            //14 Corrupted an Innocent
            case int n when (n >= 14 && n <= 14):
                return entry.Name == nameof(ConflictEnum.CorruptedanInnocent)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 6;

            //15 Blackmailed
            case int n when (n >= 15 && n <= 15):
                return entry.Name == nameof(ConflictEnum.Blackmailed)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 6;

            //16 Destruction
            case int n when (n >= 16 && n <= 16):
                return entry.Name == nameof(ConflictEnum.Destruction)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 6;

            //17 Armed Robbery
            case int n when (n >= 17 && n <= 17):
                return entry.Name == nameof(ConflictEnum.ArmedRobbery)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 6;

            //18 Violent Crime
            case int n when (n >= 18 && n <= 18):
                return entry.Name == nameof(ConflictEnum.ViolentCrime)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 7;

            //19 Murder
            case int n when (n >= 19 && n <= 19):
                return entry.Name == nameof(ConflictEnum.Murder)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 8;

            //20 Mass Murder
            case int n when (n >= 20 && n <= 20):
                return entry.Name == nameof(ConflictEnum.MassMurder)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 12;
        }
        return false;
    }
}