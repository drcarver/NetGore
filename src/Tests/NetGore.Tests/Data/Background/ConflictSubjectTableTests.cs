using NetGore.Core.Enum;
using NetGore.Data.Background;
using NetGore.Data.Interfaces;
using NetGore.Data.Models;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data.Background;

[TestFixture]
public class ConflictSubjectTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var conflictSubjectTable = new ConflictSubjectTable();
        ClassicAssert.IsTrue(conflictSubjectTable.Name == nameof(ConflictSubjectTable));

        foreach (var entry in conflictSubjectTable.Table)
        {
            ClassicAssert.IsTrue(VerifyEntry((ConflictTableEntry) entry), $"Table Name = {entry?.Name} is incorrect");
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(IConflictTableEntry entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (entry.Name)
        {
            //1	Commoner
            case nameof(ConflictSubjectEnum.Commoner):
                    return entry.ConflictPoints == 0;

            //2	Merchant
            case nameof(ConflictSubjectEnum.Merchant):
                    return entry.ConflictPoints == 0;

            //3	Tradesperson
            case nameof(ConflictSubjectEnum.Tradesperson):
                    return entry.ConflictPoints == 0;

            //4	Artisan
            case nameof(ConflictSubjectEnum.Artisan):
                    return entry.ConflictPoints == 0;

            //5	Civic or military official
            case nameof(ConflictSubjectEnum.Civicormilitaryofficial):
                    return entry.ConflictPoints == 0;

            //6	Noble
            case nameof(ConflictSubjectEnum.Noble):
                    return entry.ConflictPoints == 0;

            //7	Leader
            case nameof(ConflictSubjectEnum.Leader):
                    return entry.ConflictPoints == 0;

            //8	Clergy
            case nameof(ConflictSubjectEnum.Clergy):
                    return entry.ConflictPoints == 0;

            //9	Soldier or warrior
            case nameof(ConflictSubjectEnum.Soldierorwarrior):
                    return entry.ConflictPoints == 0;

            //10	Spellcaster
            case nameof(ConflictSubjectEnum.Spellcaster):
                    return entry.ConflictPoints == 0;

            //11	Scoundrel
            case nameof(ConflictSubjectEnum.Scoundrel):
                    return entry.ConflictPoints == 0;

            //12	Child or young person
            case nameof(ConflictSubjectEnum.Child):
                    return entry.ConflictPoints == 1;

            //13	Family member
            case nameof(ConflictSubjectEnum.Familymember):
                    return entry.ConflictPoints == 0;

            //14	Close friend
            case nameof(ConflictSubjectEnum.Closefriend):
                    return entry.ConflictPoints == 0;

            //15	Lover or former lover
            case nameof(ConflictSubjectEnum.Loverorformerlover):
                    return entry.ConflictPoints == 0;

            //16	Enemy or rival
            case nameof(ConflictSubjectEnum.Enemyorrival):
                    return entry.ConflictPoints == 0;

            //17	Gangster or underworld figure
            case nameof(ConflictSubjectEnum.Gangsterorunderworldfigure):
                    return entry.ConflictPoints == 0;

            //18	Adventurer
            case nameof(ConflictSubjectEnum.Adventurer):
                    return entry.ConflictPoints == 0;

            //19	Humanoid monster
            case nameof(ConflictSubjectEnum.Humanoidmonster):
                    return entry.ConflictPoints == 0;

            //20	Non-humanoid monster    
            case nameof(ConflictSubjectEnum.Nonhumanoidmonster):
                    return entry.ConflictPoints == 0;
        }
        return false;
    }
}