using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class CharacterDrawbackTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.CharacterDrawbackTable.Name == "Character Drawback Table");
        ClassicAssert.IsTrue(BackgroundTables.CharacterDrawbackTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.CharacterDrawbackTable.DiceSides; i++)
        {
            var entry = BackgroundTables.CharacterDrawbackTable.GetEntryByNumber(i);
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
            //01–05	Adopted by Dragons
            //case int n when (n>= 1 && n <= 5):
            //    return entry.Name == nameof(AdoptedOutsideYourRaceEnum.AdoptedbyDragons)
            //        && entry.Traits.Count == 2
            //        && entry.Traits.Contains(TraitEnum.BloodofDragons)
            //        && entry.Traits.Contains(TraitEnum.MagicalKnack);
        }
        return false;
    }
}
