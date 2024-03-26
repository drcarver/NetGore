using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class AdoptedOutsideYourRaceTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.AdoptedOutsideYourRaceTable.Name == "Adopted Outside Your Race Table");
        ClassicAssert.IsTrue(BackgroundTables.AdoptedOutsideYourRaceTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.AdoptedOutsideYourRaceTable.DiceSides; i++)
        {
            var entry = BackgroundTables.AdoptedOutsideYourRaceTable.GetEntryByNumber(i);
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
            case int n when (n>= 1 && n <= 5):
                return entry.Name == nameof(AdoptedOutsideYourRaceEnum.AdoptedbyDragons)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.BloodofDragons)
                    && entry.Traits.Contains(TraitEnum.MagicalKnack);

            //06–10	Adopted by the Fey
            case int n when (n >= 6 && n <= 10):
                return entry.Name == nameof(AdoptedOutsideYourRaceEnum.AdoptedbytheFey)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Charming)
                    && entry.Traits.Contains(TraitEnum.MagicalKnack);

            //11–13	Raised Among the Dead
            case int n when (n >= 11 && n <= 13):
                return entry.Name == nameof(AdoptedOutsideYourRaceEnum.RaisedAmongtheDead)
                    && entry.Traits.Count == 3
                    && entry.Traits.Contains(TraitEnum.Deathtouched)
                    && entry.Traits.Contains(TraitEnum.GlimpseBeyond)
                    && entry.Traits.Contains(TraitEnum.MagicalKnack);

            //14–19	Raised by Angels
            case int n when (n >= 14 && n <= 19):
                return entry.Name == nameof(AdoptedOutsideYourRaceEnum.RaisedbyAngels)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Blessed);

            //20–25	Raised by Beasts
            case int n when (n >= 20 && n <= 25):
                return entry.Name == nameof(AdoptedOutsideYourRaceEnum.RaisedbyBeasts)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Resilient)
                    && entry.Traits.Contains(TraitEnum.FeralHeart);

            //26–70	Raised by Civilized Humanoids
            case int n when (n >= 26 && n <= 70):
                return entry.Name == nameof(AdoptedOutsideYourRaceEnum.RaisedbyCivilizedHumanoids)
                    && entry.Traits.Count == 0;

            //71–95	Raised by Savage Humanoids
            case int n when (n >= 71 && n <= 95):
                return entry.Name == nameof(AdoptedOutsideYourRaceEnum.RaisedbySavageHumanoids)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Savage);

            //96–100	Fiend Raised
            case int n when (n >= 96 && n <= 100):
                return entry.Name == nameof(AdoptedOutsideYourRaceEnum.FiendRaised)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.FiendBlood)
                    && entry.Traits.Contains(TraitEnum.Damned);
        }
        return false;
    }
}
