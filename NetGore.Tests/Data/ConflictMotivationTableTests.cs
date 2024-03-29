using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class ConflictMotivationTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.ConflictMotivationTable.Name == "The Conflict Motivation Table");
        ClassicAssert.IsTrue(BackgroundTables.ConflictMotivationTable.DiceSides == 10);

        for (int i = 1; i <= BackgroundTables.ConflictMotivationTable.DiceSides; i++)
        {
            var entry = BackgroundTables.ConflictMotivationTable.GetEntryByNumber(i);
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
            //1	Justice	1
            case int n when (n>= 1 && n <= 1):
                return entry.Name == nameof(ConflictMotivationEnum.Justice)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 1;

            //2	Love	1
            case int n when (n >= 2 && n <= 2):
                return entry.Name == nameof(ConflictMotivationEnum.Love)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 1;

            //3	Pressured or Manipulated	2
            case int n when (n >= 3 && n <= 3):
                return entry.Name == nameof(ConflictMotivationEnum.PressuredorManipulated)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 2;

            //4	Religion	2
            case int n when (n >= 4 && n <= 4):
                return entry.Name == nameof(ConflictMotivationEnum.Religion)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 2;

            //5	Family	3
            case int n when (n >= 5 && n <= 5):
                return entry.Name == nameof(ConflictMotivationEnum.Family)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 3;

            //6	Money	3
            case int n when (n >= 6 && n <= 6):
                return entry.Name == nameof(ConflictMotivationEnum.Money)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 3;

            //7	Jealousy	4
            case int n when (n >= 7 && n <= 7):
                return entry.Name == nameof(ConflictMotivationEnum.Jealousy)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 4;

            //8	Hatred or Malice	4
            case int n when (n >= 8 && n <= 8):
                return entry.Name == nameof(ConflictMotivationEnum.HatredorMalice)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 4;

            //9	Pleasure	5
            case int n when (n >= 9 && n <= 9):
                return entry.Name == nameof(ConflictMotivationEnum.Pleasure)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 5;

            //10	Amusement or Entertainment	5    
            case int n when (n >= 10 && n <= 10):
                return entry.Name == nameof(ConflictMotivationEnum.AmusementorEntertainment)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 5;
        }
        return false;
    }
}