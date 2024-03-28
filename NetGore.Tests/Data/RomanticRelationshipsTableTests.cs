using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class RomanticRelationshipsTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.RomanticRelationshipsTable.Name == "Romantic Relationships Table");
        ClassicAssert.IsTrue(BackgroundTables.RomanticRelationshipsTable.DiceSides == 20);

        for (int i = 1; i <= BackgroundTables.RomanticRelationshipsTable.DiceSides; i++)
        {
            var entry = BackgroundTables.RomanticRelationshipsTable.GetEntryByNumber(i);
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
            //1–2	One Significant Relationship
            case int n when (n >= 1 && n <= 2):
                return entry.Name == nameof(RomanticRelationshipsEnum.OneSignificantRelationship)
                    && entry.Traits.Count == 0;

            //3–6	A Few Significant Relationships
            case int n when (n >= 3 && n <= 6):
                return entry.Name == nameof(RomanticRelationshipsEnum.AFewSignificantRelationships)
                    && entry.Traits.Count == 0;

            //7–9	Several Significant Relationships
            case int n when (n >= 7 && n <= 9):
                return entry.Name == nameof(RomanticRelationshipsEnum.SeveralSignificantRelationships)
                    && entry.Traits.Count == 0;

            //10–12	Current Lover
            case int n when (n >= 10 && n <= 12):
                return entry.Name == nameof(RomanticRelationshipsEnum.CurrentLover)
                    && entry.Traits.Count == 0;
                    //&& entry.Traits.Contains(TraitEnum.TrueLove);

            //13–16	Several Inconsequential Relationships
            case int n when (n >= 13 && n <= 16):
                return entry.Name == nameof(RomanticRelationshipsEnum.SeveralInconsequentialRelationships)
                    && entry.Traits.Count == 0;

            //17–18	Experience but No Substantial Relationships
            case int n when (n >= 17 && n <= 18):
                return entry.Name == nameof(RomanticRelationshipsEnum.ExperiencebutNoSubstantialRelationships)
                    && entry.Traits.Count == 0;

            //19–20	No Experience
            case int n when (n >= 19 && n <= 20):
                return entry.Name == nameof(RomanticRelationshipsEnum.NoExperience)
                    && entry.Traits.Count == 0;
        }
        return false;
    }
}
