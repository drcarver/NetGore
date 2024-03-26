using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class MajorChildhoodEventTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.MajorChildhoodEventTable.Name == "Major Childhood Event Table");
        ClassicAssert.IsTrue(BackgroundTables.MajorChildhoodEventTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.MajorChildhoodEventTable.DiceSides; i++)
        {
            var entry = BackgroundTables.MajorChildhoodEventTable.GetEntryByNumber(i);
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
            //01–05	Academy Training
            case int n when (n>= 1 && n <= 5):
                return entry.Name == nameof(MajorChildhoodEventEnum.AcademyTraining)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.FocusedMind);

            //06–10	Betrayal
            case int n when (n >= 6 && n <= 10):
                return entry.Name == nameof(MajorChildhoodEventEnum.Betrayal)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Suspicious);

            //11–15	Bullied
            case int n when (n >= 11 && n <= 15):
                return entry.Name == nameof(MajorChildhoodEventEnum.Bullied)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Bullied);

            //16–20	Competition Champion
            case int n when (n >= 16 && n <= 20):
                return entry.Name == nameof(MajorChildhoodEventEnum.CompetitionChampion)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Influence)
                    && entry.Traits.Contains(TraitEnum.Champion);

            //21–25	Death in the Family
            case int n when (n >= 21 && n <= 25):
                return entry.Name == nameof(MajorChildhoodEventEnum.DeathintheFamily)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Reactionary)
                    && entry.Traits.Contains(TraitEnum.DenytheReaper);

            //26–30	Died
            case int n when (n >= 26 && n <= 30):
                return entry.Name == nameof(MajorChildhoodEventEnum.Died)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.FearlessDefiance)
                    && entry.Traits.Contains(TraitEnum.Arisen);

            //31–35	Fall of a Major Power
            case int n when (n >= 31 && n <= 35):
                return entry.Name == nameof(MajorChildhoodEventEnum.FallofaMajorPower)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Worldly);

            //36–40	Fell in with a Bad Crowd
            case int n when (n >= 36 && n <= 40):
                return entry.Name == nameof(MajorChildhoodEventEnum.FellinwithaBadCrowd)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.ChildoftheStreets);

            //41–45	First Kill
            case int n when (n >= 41 && n <= 45):
                return entry.Name == nameof(MajorChildhoodEventEnum.FirstKill)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Killer)
                    && entry.Traits.Contains(TraitEnum.InnocentBlood);

            //46–50	Troubled First Love
            case int n when (n >= 46 && n <= 50):
                return entry.Name == nameof(MajorChildhoodEventEnum.TroubledFirstLove)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Worldly);

            //51–55	Imprisoned
            case int n when (n >= 51 && n <= 55):
                return entry.Name == nameof(MajorChildhoodEventEnum.Imprisoned)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Criminal)
                    && entry.Traits.Contains(TraitEnum.Liberator);

            //56–60	Inheritance
            case int n when (n >= 56 && n <= 60):
                return entry.Name == nameof(MajorChildhoodEventEnum.Inheritance)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.RichParents);

            //61–65	Kidnapped
            case int n when (n >= 61 && n <= 65):
                return entry.Name == nameof(MajorChildhoodEventEnum.Kidnapped)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Canter)
                    && entry.Traits.Contains(TraitEnum.Liberator);

            //66–70	Magical Gift
            case int n when (n >= 66 && n <= 70):
                return entry.Name == nameof(MajorChildhoodEventEnum.MagicalGift)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.MagicalTalent);

            //71–75	Major Disaster
            case int n when (n >= 71 && n <= 75):
                return entry.Name == nameof(MajorChildhoodEventEnum.MajorDisaster)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.Resilient)
                    && entry.Traits.Contains(TraitEnum.Unforgotten);

            //76–80	Mentorship/Patronage
            case int n when (n >= 76 && n <= 80):
                return entry.Name == nameof(MajorChildhoodEventEnum.MentorshipPatronage)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Mentored);

            //81–85	Met a Fantastic Creature
            case int n when (n >= 81 && n <= 85):
                return entry.Name == nameof(MajorChildhoodEventEnum.MetaFantasticCreature)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.GiftedAdept);

            //86–90	Ordinary Childhood
            case int n when (n >= 86 && n <= 90):
                return entry.Name == nameof(MajorChildhoodEventEnum.OrdinaryChildhood)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Ordinary);

            //91–95	Raiders
            case int n when (n >= 91 && n <= 95):
                return entry.Name == nameof(MajorChildhoodEventEnum.Raiders)
                    && entry.Traits.Count == 3
                    && entry.Traits.Contains(TraitEnum.AxetoGrind)
                    && entry.Traits.Contains(TraitEnum.Vengeance)
                    && entry.Traits.Contains(TraitEnum.Foeslayer);

            //96–100	The War
            case int n when (n >= 96 && n <= 100):
                return entry.Name == nameof(MajorChildhoodEventEnum.War)
                    && entry.Traits.Count == 2
                    && entry.Traits.Contains(TraitEnum.VagabondChild)
                    && entry.Traits.Contains(TraitEnum.DenytheReaper);
        }
        return false;
    }
}
