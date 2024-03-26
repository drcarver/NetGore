using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class CircumstanceofBirthTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.CircumstanceofBirthTable.Name == "Circumstance of Birth Table");
        ClassicAssert.IsTrue(BackgroundTables.CircumstanceofBirthTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.CircumstanceofBirthTable.DiceSides; i++)
        {
            var entry = BackgroundTables.CircumstanceofBirthTable.GetEntryByNumber(i);
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
            //01–40	Lower-Class Birth
            case int n when (n>= 1 && n <= 40):
                return entry.Name == nameof(CircumstanceofBirthEnum.LowerClassBirth)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.PovertyStricken);

            //41–65	Middle-Class Birth
            case int n when (n >= 41 && n <= 65):
                return entry.Name == nameof(CircumstanceofBirthEnum.MiddleClassBirth)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Artisan)
                    && entry.Traits.Contains(TraitEnum.Merchant);

            //66–70	Noble Birth
            case int n when (n >= 66 && n <= 70):
                return entry.Name == nameof(CircumstanceofBirthEnum.NobleBirth)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Influence)
                    && entry.Traits.Contains(TraitEnum.RichParents);
            
            //71–72	Adopted Outside Your Race
            case int n when (n >= 71 && n <= 72):
                return entry.Name == nameof(CircumstanceofBirthEnum.AdoptedOutsideYourRace)
                    && entry.Traits.Count == 0;
            
            //73–77	Adopted
            case int n when (n >= 73 && n <= 77):
                return entry.Name == nameof(CircumstanceofBirthEnum.Adopted)
                    && entry.Traits.Count == 0;

            //78–81	Bastard Born
            case int n when (n >= 73 && n <= 81):
                return entry.Name == nameof(CircumstanceofBirthEnum.BastardBorn)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Bastard)
                    && entry.Traits.Contains(TraitEnum.Shamed);

            //82	Blessed Birth
            case int n when (n >= 82 && n <= 82):
                return entry.Name == nameof(CircumstanceofBirthEnum.BlessedBirth)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Blessed)
                    && entry.Traits.Contains(TraitEnum.Birthmark);

            //83–84	Born of Violence
            case int n when (n >= 83 && n <= 84):
                return entry.Name == nameof(CircumstanceofBirthEnum.BornofViolence)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.AxetoGrind)
                    && entry.Traits.Contains(TraitEnum.Bastard);

            //85	Born out of Time
            case int n when (n >= 85 && n <= 85):
                return entry.Name == nameof(CircumstanceofBirthEnum.BornoutofTime)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.ScholaroftheGreatBeyond);

            //86–87	Born into Bondage
            case int n when (n >= 86 && n <= 87):
                return entry.Name == nameof(CircumstanceofBirthEnum.BornintoBondage)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.LifeofToil);

            //88	Cursed Birth
            case int n when (n >= 88 && n <= 88):
                return entry.Name == nameof(CircumstanceofBirthEnum.CursedBirth)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.FiendBlood)
                    && entry.Traits.Contains(TraitEnum.Accursed);

            //89–90	Dishonored Family
            case int n when (n >= 89 && n <= 90):
                return entry.Name == nameof(CircumstanceofBirthEnum.DishonoredFamily)
                    && entry.Traits.Count == 3
                    && entry.Traits.Contains(TraitEnum.Reactionary)
                    && entry.Traits.Contains(TraitEnum.Redemption)
                    && entry.Traits.Contains(TraitEnum.LostLegacy);

            //91–92	Heir to a Legacy
            case int n when (n >= 91 && n <= 92):
                return entry.Name == nameof(CircumstanceofBirthEnum.HeirtoaLegacy)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Influence)
                    && entry.Traits.Contains(TraitEnum.RichParents);

            //93–94	Left to Die
            case int n when (n >= 93 && n <= 94):
                return entry.Name == nameof(CircumstanceofBirthEnum.LefttoDie)
                    && entry.Traits.Count == 3
                    && entry.Traits.Contains(TraitEnum.Courageous)
                    && entry.Traits.Contains(TraitEnum.Savage)
                    && entry.Traits.Contains(TraitEnum.Arisen);

            //95	Marked by the Gods
            case int n when (n >= 95 && n <= 95):
                return entry.Name == nameof(CircumstanceofBirthEnum.MarkedbytheGods)
                    && entry.Traits.Count == 3
                    && entry.Traits.Contains(TraitEnum.Birthmark)
                    && entry.Traits.Contains(TraitEnum.SacredTouch)
                    && entry.Traits.Contains(TraitEnum.Prophet);

            //96	Energy Infused
            case int n when (n >= 96 && n <= 96):
                return entry.Name == nameof(CircumstanceofBirthEnum.EnergyInfused)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.SacredConduit)
                    && entry.Traits.Contains(TraitEnum.SacredTouch);
    
            //97	Progeny of Power
            case int n when (n >= 97 && n <= 97):
                return entry.Name == nameof(CircumstanceofBirthEnum.ProgenyofPower)
                    && entry.Traits.Count == 3
                    && entry.Traits.Contains(TraitEnum.MagicalTalent)
                    && entry.Traits.Contains(TraitEnum.SacredTouch)
                    && entry.Traits.Contains(TraitEnum.Charming);

            //98	Prophesied
            case int n when (n >= 98 && n <= 98):
                return entry.Name == nameof(CircumstanceofBirthEnum.Prophesied)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Prophesied);

            //99	Reincarnated
            case int n when (n >= 99 && n <= 99):
                return entry.Name == nameof(CircumstanceofBirthEnum.Reincarnated)
                    && entry.Traits.Count == 3
                    && entry.Traits.Contains(TraitEnum.Reincarnated)
                    && entry.Traits.Contains(TraitEnum.Arisen)
                    && entry.Traits.Contains(TraitEnum.ForgottenPast);

            //100	The Omen
            case int n when (n >= 100 && n <= 100):
                return entry.Name == nameof(CircumstanceofBirthEnum.TheOmen)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Omen);
        }
        return false;
    }
}

