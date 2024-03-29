using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class ConflictSubjectTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.ConflictSubjectTable.Name == "The Conflicts Subject Table");
        ClassicAssert.IsTrue(BackgroundTables.ConflictSubjectTable.DiceSides == 20);

        for (int i = 1; i <= BackgroundTables.ConflictSubjectTable.DiceSides; i++)
        {
            var entry = BackgroundTables.ConflictSubjectTable.GetEntryByNumber(i);
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
            //1	Commoner
            case int n when (n>= 1 && n <= 1):
                return entry.Name == nameof(ConflictSubjectEnum.Commoner)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //2	Merchant
            case int n when (n >= 2 && n <= 2):
                return entry.Name == nameof(ConflictSubjectEnum.Merchant)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //3	Tradesperson
            case int n when (n >= 3 && n <= 3):
                return entry.Name == nameof(ConflictSubjectEnum.Tradesperson)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //4	Artisan
            case int n when (n >= 4 && n <= 4):
                return entry.Name == nameof(ConflictSubjectEnum.Artisan)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //5	Civic or military official
            case int n when (n >= 5 && n <= 5):
                return entry.Name == nameof(ConflictSubjectEnum.Civicormilitaryofficial)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //6	Noble
            case int n when (n >= 6 && n <= 6):
                return entry.Name == nameof(ConflictSubjectEnum.Noble)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //7	Leader
            case int n when (n >= 7 && n <= 7):
                return entry.Name == nameof(ConflictSubjectEnum.Leader)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //8	Clergy
            case int n when (n >= 8 && n <= 8):
                return entry.Name == nameof(ConflictSubjectEnum.Clergy)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //9	Soldier or warrior
            case int n when (n >= 9 && n <= 9):
                return entry.Name == nameof(ConflictSubjectEnum.Soldierorwarrior)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //10	Spellcaster
            case int n when (n >= 10 && n <= 10):
                return entry.Name == nameof(ConflictSubjectEnum.Spellcaster)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //11	Scoundrel
            case int n when (n >= 11 && n <= 11):
                return entry.Name == nameof(ConflictSubjectEnum.Scoundrel)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //12	Child or young person
            case int n when (n >= 12 && n <= 12):
                return entry.Name == nameof(ConflictSubjectEnum.Child)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 1;

            //13	Family member
            case int n when (n >= 13 && n <= 13):
                return entry.Name == nameof(ConflictSubjectEnum.Familymember)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //14	Close friend
            case int n when (n >= 14 && n <= 14):
                return entry.Name == nameof(ConflictSubjectEnum.Closefriend)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //15	Lover or former lover
            case int n when (n >= 15 && n <= 15):
                return entry.Name == nameof(ConflictSubjectEnum.Loverorformerlover)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //16	Enemy or rival
            case int n when (n >= 16 && n <= 16):
                return entry.Name == nameof(ConflictSubjectEnum.Enemyorrival)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //17	Gangster or underworld figure
            case int n when (n >= 17 && n <= 17):
                return entry.Name == nameof(ConflictSubjectEnum.Gangsterorunderworldfigure)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //18	Adventurer
            case int n when (n >= 18 && n <= 18):
                return entry.Name == nameof(ConflictSubjectEnum.Adventurer)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //19	Humanoid monster
            case int n when (n >= 19 && n <= 19):
                return entry.Name == nameof(ConflictSubjectEnum.Humanoidmonster)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;

            //20	Non-humanoid monster    
            case int n when (n >= 20 && n <= 20):
                return entry.Name == nameof(ConflictSubjectEnum.Nonhumanoidmonster)
                    && entry.Traits.Count == 0
                    && entry.ConflictPoints == 0;
        }
        return false;
    }
}