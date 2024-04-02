using NetGore.Core.Enum;
using NetGore.Data.Background;
using NetGore.Data.Models;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class CharacterAdvancementTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        var characterAdvancementTable = new CharacterAdvancementTable();
        ClassicAssert.IsTrue(characterAdvancementTable.Name == nameof(CharacterAdvancementTable));
        ClassicAssert.IsTrue(characterAdvancementTable.DiceSides == 20);

        for (int i = 0; i <= 400000; i++)
        {
            var entry = characterAdvancementTable.GetEntryByExperiencePoints(i);
            if (i <= 355000)
            {
                ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry Level={entry?.Level} - ExperiencePoints = {entry?.ExperiencePoints.Start.Value}-{entry?.ExperiencePoints.End.Value} is incorrect");
            }
            else 
            {
                ClassicAssert.IsTrue(VerifyEntry(i, entry), $"Table entry Level={entry?.Level} - ExperiencePoints > {entry?.ExperiencePoints.Start.Value} is incorrect");
            }
        }
    }

    /// <summary>
    /// Verify a random table entry
    /// </summary>
    /// <param name="i">The index for the table</param>
    /// <param name="entry">The random entry</param>
    /// <returns>True if correct</returns>
    private static bool VerifyEntry(int i, CharacterAdvancementEntry? entry)
    {
        if (entry == null)
        {
            return false;
        }

        switch (i)
        {
            //0-299 1 +2
            case int n when (n >= 0 && n < 300):
                return entry.Level == 1
                    && entry.ProficiencyBonus == 2;

            //300-899 2 +2
            case int n when (n >= 300 && n < 900):
                return entry.Level == 2
                    && entry.ProficiencyBonus == 2;

            //900-2699 3 +2
            case int n when (n >= 900 && n < 2700):
                return entry.Level == 3
                    && entry.ProficiencyBonus == 2;

            //2700-6499 4 +2
            case int n when (n >= 2700 && n < 6500):
                return entry.Level == 4
                    && entry.ProficiencyBonus == 2;

            //6500-13,999 5 +2
            case int n when (n >= 6500 && n < 14000):
                return entry.Level == 5
                    && entry.ProficiencyBonus == 3;

            //14,000-22,999 6 +3
            case int n when (n >= 14000 && n < 23000):
                return entry.Level == 6
                    && entry.ProficiencyBonus == 3;

            //23,000-33,999 7 +3
            case int n when (n >= 23000 && n < 34000):
                return entry.Level == 7
                    && entry.ProficiencyBonus == 3;

            //34,000-47,999 8 +3
            case int n when (n >= 34000 && n < 48000):
                return entry.Level == 8
                    && entry.ProficiencyBonus == 3;

            //48,000-63,999 9 +4
            case int n when (n >= 48000 && n < 64000):
                return entry.Level == 9
                    && entry.ProficiencyBonus == 4;

            //64,000-84,999 10 +4
            case int n when (n >= 64000 && n < 85000):
                return entry.Level == 10
                    && entry.ProficiencyBonus == 4;

            //85,000-99,999 11 +4
            case int n when (n >= 85000 && n < 100000):
                return entry.Level == 11
                    && entry.ProficiencyBonus == 4;

            //100,000-119,999 12 +4
            case int n when (n >= 100000 && n < 120000):
                return entry.Level == 12
                    && entry.ProficiencyBonus == 4;

            //120,000-139,999 13 +5
            case int n when (n >= 120000 && n < 140000):
                return entry.Level == 13
                    && entry.ProficiencyBonus == 5;

            //140,000-164,999 14 +5
            case int n when (n >= 140000 && n < 165000):
                return entry.Level == 14
                    && entry.ProficiencyBonus == 5;

            //165,000-194,999 15 +5
            case int n when (n >= 165000 && n < 195000):
                return entry.Level == 15
                    && entry.ProficiencyBonus == 5;

            //195,000-224,999 16 +5
            case int n when (n >= 195000 && n < 225000):
                return entry.Level == 16
                    && entry.ProficiencyBonus == 5;

            //225,000-264,999 17 +6
            case int n when (n >= 225000 && n < 265000):
                return entry.Level == 17
                    && entry.ProficiencyBonus == 6;

            //265,000-304,999 18 +6
            case int n when (n >= 265000 && n < 305000):
                return entry.Level == 18
                    && entry.ProficiencyBonus == 6;

            //305,000-354,999 19 +6
            case int n when (n >= 305000 && n < 355000):
                return entry.Level == 19
                    && entry.ProficiencyBonus == 6;

            //355,000-int.MaxValue 20 +6
            case int n when (n >= 355000 && n < int.MaxValue):
                return entry.Level == 20
                    && entry.ProficiencyBonus == 6;

                //305,000 19 +6
                //355,000 20 +6
        }
        return false;
    }
}

