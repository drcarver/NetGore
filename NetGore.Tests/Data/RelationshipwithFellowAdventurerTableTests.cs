using NetGore.Core.Enum;
using NetGore.Core.Models;
using NetGore.Data.Background;

using NUnit.Framework.Legacy;

namespace NetGore.Tests.Data;

[TestFixture]
public class RelationshipwithFellowAdventurerTableTests
{
    [Test]
    public void AreTableEntriesCorrect()
    {
        ClassicAssert.IsTrue(BackgroundTables.RelationshipwithFellowAdventurerTable.Name == "Relationship with Fellow Adventurer Table");
        ClassicAssert.IsTrue(BackgroundTables.RelationshipwithFellowAdventurerTable.DiceSides == 100);

        for (int i = 1; i <= BackgroundTables.RelationshipwithFellowAdventurerTable.DiceSides; i++)
        {
            var entry = BackgroundTables.RelationshipwithFellowAdventurerTable.GetEntryByNumber(i);
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
            //01–05	Family
            case int n when (n>= 1 && n <= 5):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Family)
                    && entry.Traits.Count == 0;

            //06–10	Friend of a friend
            case int n when (n >= 6 && n <= 10):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Friendofafriend)
                    && entry.Traits.Count == 0;

            //11–15	Tavern buddies
            case int n when (n >= 11 && n <= 15):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Tavernbuddies)
                    && entry.Traits.Count == 0;

            //16–20	Hunting companions
            case int n when (n >= 16 && n <= 20):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Huntingcompanions)
                    && entry.Traits.Count == 0;

            //21–25	Business associates, current or former
            case int n when (n >= 21 && n <= 25):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Businessassociates)
                    && entry.Traits.Count == 0;

            //26–30	Contractor and employer
            case int n when (n >= 26 && n <= 30):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Contractorandemployer)
                    && entry.Traits.Count == 0;

            //31–35	Former allies
            case int n when (n >= 31 && n <= 35):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Formerallies)
                    && entry.Traits.Count == 0;

            //36–40	Former enemies
            case int n when (n >= 36 && n <= 40):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Formerenemies)
                    && entry.Traits.Count == 0;

            //41–45	Friendly competitors
            case int n when (n >= 41 && n <= 45):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Friendlycompetitors)
                    && entry.Traits.Count == 0;

            //46–50	Romantic competitors, current or former
            case int n when (n >= 46 && n <= 50):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Romanticcompetitors)
                    && entry.Traits.Count == 0;

            //51–55	Know each other by reputation only
            case int n when (n >= 51 && n <= 55):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.KnownByRepution)
                    && entry.Traits.Count == 0;

            //56–60	Former inmates(prison, asylum, or captivity) or former inmate and captor
            case int n when (n >= 56 && n <= 60):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Formerinmates)
                    && entry.Traits.Count == 0;

            //61–65	Criminal connections
            case int n when (n >= 61 && n <= 65):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Criminalconnections)
                    && entry.Traits.Count == 0;

            //66–70	Servants or apprentices to the same master
            case int n when (n >= 66 && n <= 70):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Servants)
                    && entry.Traits.Count == 0;

            //71–75	Met on a pilgrimage, caravan, or journey
            case int n when (n >= 71 && n <= 75):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Metonapilgrimage)
                    && entry.Traits.Count == 0;

            //76–80	Veterans of a skirmish or war
            case int n when (n >= 76 && n <= 80):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Veterans)
                    && entry.Traits.Count == 0;

            //81–85	Follow(or followed) the same faith or cult
            case int n when (n >= 81 && n <= 85):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Follow)
                    && entry.Traits.Count == 0;

            //86–90	Best friends
            case int n when (n >= 86 && n <= 90):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Bestfriends)
                    && entry.Traits.Count == 0;

            //91–95	Gaming or gambling associates
            case int n when (n >= 91 && n <= 95):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Gaming)
                    && entry.Traits.Count == 0;

            //96–100	From the same hometown or region
            case int n when (n >= 96 && n <= 100):
                return entry.Name == nameof(RelationshipwithFellowAdventurerEnum.Hometown)
                    && entry.Traits.Count == 0;
        }
        return false;
    }
}
