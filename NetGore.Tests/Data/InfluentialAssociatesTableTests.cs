using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class InfluentialAssociatesTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.InfluentialAssociatesTable.Name == "Influential Associates Table");
        ClassicAssert.IsTrue(BackgroundTables.InfluentialAssociatesTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.InfluentialAssociatesTable.DiceSides; i++)
        {
            var entry = BackgroundTables.InfluentialAssociatesTable.GetEntryByNumber(i);
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
            //01–05	The Hunter
            case int n when (n>= 1 && n <= 5):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheHunter)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.ChildofNature);

            //06–10	The Pariah
            case int n when (n >= 6 && n <= 10):
                return entry.Name == nameof(InfluentialAssociatesEnum.ThePariah)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Suspicious);

            //11–15	The Confidante
            case int n when (n >= 11 && n <= 15):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheConfidante)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Trustworthy);

            //16–20	The Mentor
            case int n when (n >= 16 && n <= 20):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheMentor)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Mentored);

            //21–25	The Mercenary
            case int n when (n >= 21 && n <= 25):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheMercenary)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Mercenary);

            //26–30	The Lover
            case int n when (n >= 26 && n <= 30):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheLover)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Charming);
                    //&& entry.Traits.Contains(TraitEnum.TrueLove);

            //31–35	The Fool
            case int n when (n >= 31 && n <= 35):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheFool)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Unpredictable);

            //36–40	The Liege Lord
            case int n when (n >= 36 && n <= 40):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheLiegeLord)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Influence);

            //41–45	The Relative
            case int n when (n >= 41 && n <= 45):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheRelative)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Oathbound);

            //46–50	The Boss
            case int n when (n >= 46 && n <= 50):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheBoss)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.NaturalBornLeader);

            //51–55	The Academic
            case int n when (n >= 51 && n <= 55):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheAcademic)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.MathematicalProdigy);

            //56–60	The Criminal
            case int n when (n >= 56 && n <= 60):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheCriminal)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Canter);

            //61–65	The Seer
            case int n when (n >= 61 && n <= 65):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheSeer)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.ScholaroftheGreatBeyond);

            //66–70	The Mystic
            case int n when (n >= 66 && n <= 70):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheMystic)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.ChildoftheTemple);

            //71–75	The Dead One
            case int n when (n >= 71 && n <= 75):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheDeadOne)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Deathtouched);
                    //&& entry.Traits.Contains(TraitEnum.GlimpseBeyond);

            //76–80	The Fiend
            case int n when (n >= 76 && n <= 80):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheFiend)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Possessed);
                    //&& entry.Traits.Contains(TraitEnum.Damned);

            //81–85	The Wanderer
            case int n when (n >= 81 && n <= 85):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheWanderer)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Worldly);

            //86–90	The Champion
            case int n when (n >= 86 && n <= 90):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheChampion)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Ambitious);

            //91–95	The Craftsperson
            case int n when (n >= 91 && n <= 95):
                return entry.Name == nameof(InfluentialAssociatesEnum.TheCraftsperson)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.Artisan);

            //96–100	Well-Connected Friend
            case int n when (n >= 96 && n <= 100):
                return entry.Name == nameof(InfluentialAssociatesEnum.WellConnectedFriend)
                    && entry.Traits.Count == 1
                    && entry.Traits.Contains(TraitEnum.WellInformed);
        }
        return false;
    }
}
